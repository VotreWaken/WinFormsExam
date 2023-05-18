using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenTK;
using System.IO;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using Program;
using static System.Windows.Forms.AxHost;
using System.Threading;
using static System.Formats.Asn1.AsnWriter;

namespace WinFormsApp4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        double ScreenW, ScreenH;
        private float devX;
        private float devY;


        private int elements_count = 0;

        private int pointPosition = 0;

        private InputHandler inputHandler;
        public void loadform(object Form)
        {
            if (this.MainPanel.Controls.Count > 0)
                this.MainPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(f);
            this.MainPanel.Tag = f;
            f.Show();
        }
        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnStandartCalc_Click(object sender, EventArgs e)
        {
            loadform(new DefaultCalc());
        }
        private void btnProgrammerCalc_Click(object sender, EventArgs e)
        {
            loadform(new ProgCalc());
        }
        private void btnScienceCalc_Click(object sender, EventArgs e)
        {
            loadform(new ScienceCalc());
        }

        private void AnT_Load(object sender, EventArgs e)
        {
            GL.Viewport(0, 0, AnT.Width, AnT.Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(0.0, 30.0 * (float)AnT.Width / (float)AnT.Height, 0.0, 30.0, -1, 1);
            GL.MatrixMode(MatrixMode.Modelview);
            _camera = new Camera(Vector3.UnitZ * 3, AnT.Width / AnT.Height);
            //a = OpenTexturedObj("Sphere.obj", "Earth.jpg");
            a = OpenTexturedObj("CubeSize.obj", "crate_1.jpg");

            inputHandler = new InputHandler(AnT);
            inputHandler.mouseDownListeners.Add(MouseButtons.Left, (x, y) => mouseLeftDown = true);
            inputHandler.mouseDownListeners.Add(MouseButtons.Right, (x, y) => mouseRightDown = true);
            inputHandler.mouseDownListeners.Add(MouseButtons.Middle, (x, y) => mouseMiddleDown = true);

            inputHandler.mouseUpListeners.Add(MouseButtons.Left, (x, y) => mouseLeftDown = false);
            inputHandler.mouseUpListeners.Add(MouseButtons.Right, (x, y) => mouseRightDown = false);
            inputHandler.mouseUpListeners.Add(MouseButtons.Middle, (x, y) => mouseMiddleDown = false);

            inputHandler.mouseMoved += (int x, int y) =>
            {
                if (mouseLastX != -1 && mouseLastY != -1)
                {
                    if (mouseLeftDown)
                    {
                        int moveX = x - mouseLastX;
                        int moveY = y - mouseLastY;

                        float mag = (float)Math.Sqrt(moveX * moveX + moveY * moveY) / 2f;
                        foreach (var obj in _mainTexturedObjects)
                        {
                            //obj.RotateWheel(mag, moveY, moveX, 0);
                            obj.SetRotationX(mouseLastX);
                            //obj.SetRotationY(y / 20);
                            //obj.SetRotationZ(x / y);
                        }
                        AnT.Invalidate();
                    }
                }

                mouseLastX = x;
                mouseLastY = y;
            };

            inputHandler.mouseWheelMoved += (int delta) =>
            {
                scale += delta / SystemInformation.MouseWheelScrollDelta * 0.1f;

                // keep scale between 0.1 - 10
                scale = Math.Min(2f, Math.Max(0.1f, scale ));
                foreach (var obj in _mainTexturedObjects)
                {
                    obj.MouseWheelDown(scale);
                }
                AnT.Invalidate();

            };
        }

        private void AnT_MouseMove(object sender, MouseEventArgs e)
        {

        }
        private int mouseLastX = -1;
        private int mouseLastY = -1;
        private bool mouseLeftDown = false;
        private bool mouseRightDown = false;
        private bool mouseMiddleDown = false;
        private readonly List<TexturedObject> _mainTexturedObjects = new List<TexturedObject>();
        public Camera _camera;
        private Shader _textureShader;
        private void Draw()
        {
            GL.ClearColor(Color.FromArgb(28, 14, 73));
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.LoadIdentity();

            GL.Color3(0, 0, 0);
            GL.PushMatrix();
            GL.Translate(20, 15, 0);
            RotateObjectNew();

            Render3DObjects();
            AnT.SwapBuffers();
        }
        public void RotateTexturedObject(float x, float y, float z, int handle)
        {
            _mainTexturedObjects[handle].AddRotationX(x);
        }
        int a;
        float x = 0;
        void RotateObjectNew()
        {
            RotateTexturedObject(x, 0, 0, a);
            x = 0.01f;
        }
        void AddRotate(float x, int handle)
        {
            _mainTexturedObjects[handle].AddRotationX(x);
        }
        public const string TextureFrag =
"#version 330\r\n\r\nout vec4 FragColor;\r\nuniform sampler2D texture0;\r\n\r\nin vec3 Normal;\r\nin vec3 FragPos;\r\nin vec2 textureCords;\r\n\r\nvoid main()\r\n{\r\n    FragColor = texture(texture0, textureCords);\r\n}";


        public const string TextureVert =
              "#version 330\r\n\r\nlayout (location = 0) in vec3 aPos;\r\nlayout (location = 1) in vec3 aNormal;\r\nlayout (location = 2) in vec2 aTexture;\r\n\r\nuniform mat4 model;\r\nuniform mat4 view;\r\nuniform mat4 projection;\r\n\r\nout vec3 Normal;\r\nout vec3 FragPos;\r\nout vec2 textureCords;\r\n\r\nvoid main()\r\n{\r\n    gl_Position = vec4(aPos, 1.0) * model * view * projection;\r\n    textureCords = aTexture;\r\n    FragPos = vec3(vec4(aPos, 1.0) * model);\r\n    Normal = -(aNormal * mat3(transpose(inverse(model))));\r\n}";

        public int OpenTexturedObj(string obj, string texture)
        {
            _textureShader = new Shader(TextureVert, TextureFrag);
            _mainTexturedObjects.Add(new TexturedObject(obj, _textureShader, texture));
            return _mainTexturedObjects.Count - 1;
        }
        static public float scale = 1f;
        public void Render3DObjects()
        {
            GL.Enable(EnableCap.DepthTest);
            foreach (var obj in _mainTexturedObjects) obj.Show(_camera);
            GL.Disable(EnableCap.DepthTest);
        }
        private class TexturedObject
        {
            private readonly int _mainObject;
            private readonly Shader _shader;
            private readonly Texture _texture;
            private readonly int _vertexBufferObject;
            private readonly float[] _vertices;
            private Vector3 _pos;
            private float _rotX, _rotY, _rotZ;

            public TexturedObject(string path, Shader textureShader, string texturePath)
            {
                _vertices = LoadObjTextured(path);

                _vertexBufferObject = GL.GenBuffer();
                GL.BindBuffer(BufferTarget.ArrayBuffer, _vertexBufferObject);
                GL.BufferData(BufferTarget.ArrayBuffer, _vertices.Length * sizeof(float), _vertices,
                    BufferUsageHint.StaticDraw);

                _mainObject = GL.GenVertexArray();
                GL.BindVertexArray(_mainObject);

                var positionLocation = textureShader.GetAttribLocation("aPos");
                GL.EnableVertexAttribArray(positionLocation);
                GL.VertexAttribPointer(positionLocation, 3, VertexAttribPointerType.Float, false, 8 * sizeof(float), 0);

                var normalLocation = textureShader.GetAttribLocation("aNormal");
                GL.EnableVertexAttribArray(normalLocation);
                GL.VertexAttribPointer(normalLocation, 3, VertexAttribPointerType.Float, false, 8 * sizeof(float),
                    3 * sizeof(float));

                var textureLocation = textureShader.GetAttribLocation("aTexture");
                GL.EnableVertexAttribArray(textureLocation);
                GL.VertexAttribPointer(textureLocation, 2, VertexAttribPointerType.Float, false, 8 * sizeof(float),
                    6 * sizeof(float));

                _texture = new Texture(texturePath, TextureMinFilter.Nearest, TextureMagFilter.Nearest);
                _texture.Use();
                _rotX = 0.0f;
                _rotY = 0.0f;
                _rotZ = 89.5f;
                _pos = new Vector3(0.0f, 0.0f, 0.0f);
                _shader = textureShader;

            }

            private static float[] LoadObjTextured(string path)
            {
                var lines = File.ReadAllLines(path);
                var vertices = new List<float[]>();
                var textureCords = new List<float[]>();
                var final = new List<float>();
                foreach (var line in lines)
                {
                    var lineSlitted = line.Split(' ');
                    if (lineSlitted[0] == "v")
                    {
                        var toAdd = new float[3];
                        toAdd[0] = float.Parse(lineSlitted[1], CultureInfo.InvariantCulture);
                        toAdd[1] = float.Parse(lineSlitted[2], CultureInfo.InvariantCulture);
                        toAdd[2] = float.Parse(lineSlitted[3], CultureInfo.InvariantCulture);
                        vertices.Add(toAdd);
                    }

                    if (lineSlitted[0] == "vt")
                    {
                        var toAdd = new float[2];
                        toAdd[0] = float.Parse(lineSlitted[1], CultureInfo.InvariantCulture);
                        toAdd[1] = -(float.Parse(lineSlitted[2], CultureInfo.InvariantCulture));
                        textureCords.Add(toAdd);
                    }

                    if (lineSlitted[0] == "f")
                    {

                        var t1 = lineSlitted[1].Split('/');
                        var t2 = lineSlitted[2].Split('/');
                        var t3 = lineSlitted[3].Split('/');


                        var v1 = vertices[int.Parse(t1[0], CultureInfo.InvariantCulture) - 1];
                        if (int.Parse(t2[0], CultureInfo.InvariantCulture) - 1 >= 0 && vertices.Count > int.Parse(t2[0], CultureInfo.InvariantCulture) - 1)
                        {
                            var v2 = vertices[int.Parse(t2[0], CultureInfo.InvariantCulture) - 1];
                            var v3 = vertices[int.Parse(t3[0], CultureInfo.InvariantCulture) - 1];

                            var tex1 = textureCords[int.Parse(t1[1], CultureInfo.InvariantCulture) - 1];
                            var tex2 = textureCords[int.Parse(t2[1], CultureInfo.InvariantCulture) - 1];
                            var tex3 = textureCords[int.Parse(t3[1], CultureInfo.InvariantCulture) - 1];


                            var v01 = new Vector3(v1[0], v1[1], v1[2]);
                            var v02 = new Vector3(v2[0], v2[1], v2[2]);
                            var v03 = new Vector3(v3[0], v3[1], v3[2]);


                            var l1 = v02 - v01;
                            var l2 = v03 - v01;



                            var n = Vector3.Cross(l2, l1);


                            final.Add(v1[0]);
                            final.Add(v1[1]);
                            final.Add(v1[2]);
                            final.Add(n.X);
                            final.Add(n.Y);
                            final.Add(n.Z);
                            final.Add(tex1[0]);
                            final.Add(tex1[1]);
                            final.Add(v2[0]);
                            final.Add(v2[1]);
                            final.Add(v2[2]);
                            final.Add(n.X);
                            final.Add(n.Y);
                            final.Add(n.Z);
                            final.Add(tex2[0]);
                            final.Add(tex2[1]);
                            final.Add(v3[0]);
                            final.Add(v3[1]);
                            final.Add(v3[2]);
                            final.Add(n.X);
                            final.Add(n.Y);
                            final.Add(n.Z);
                            final.Add(tex3[0]);
                            final.Add(tex3[1]);
                        }
                    }
                }


                return final.ToArray();
            }

            public void MouseWheelDown(float scale)
            {
                _pos = new Vector3(0.0f, 0.0f, scale);
            }
            public void Show(Camera camera)
            {

                GL.BindVertexArray(_mainObject);

                _texture.Use();
                _shader.Use();
                _shader.SetMatrix4("model",
                    Matrix4.CreateRotationX(_rotX) * Matrix4.CreateRotationX(_rotY) * Matrix4.CreateRotationZ(_rotZ) *
                    Matrix4.CreateTranslation(_pos));
                _shader.SetMatrix4("view", camera.GetViewMatrix());
                _shader.SetMatrix4("projection", camera.GetProjectionMatrix());

                //textureShader.SetVector3("lightColor", lamp.lightColor);
                //textureShader.SetVector3("lightPos", lamp.pos);
                GL.DrawArrays(PrimitiveType.Triangles, 0, _vertices.Length / 8);
            }
            public void AddRotationX(float x)
            {
                _rotX += x;
            }
            public void SetRotationX(float angle)
            {
                _rotX = angle / 100;
            }
            public void SetRotationY(float angle)
            {
                _rotY = angle;
            }

            public void SetRotationZ(float angle)
            {
                _rotZ = angle;
            }

            public void SetPositionInSpace(float x, float y, float z)
            {
                _pos = new Vector3(x, y, z);
            }

            public void Dispose()
            {
                GL.DeleteBuffer(_vertexBufferObject);
                GL.DeleteVertexArray(_mainObject);
                GL.DeleteTexture(_texture.Handle);
            }
        }

        private void DatesBtn_Click(object sender, EventArgs e)
        {
            loadform(new DatesForm());
        }

        private void ValuteConvertBtn_Click(object sender, EventArgs e)
        {
            loadform(new CurrencyForm());
        }

        private void FunctionBtn_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if ((float)AnT.Width <= (float)AnT.Height)
            {
                ScreenW = 30.0;
                ScreenH = 30.0 * (float)AnT.Height / (float)AnT.Width;
                GL.Ortho(0.0, ScreenW, 0.0, ScreenH, -1, 1);
            }
            else
            {
                ScreenW = 30.0;
                ScreenH = 30.0 * (float)AnT.Width / (float)AnT.Height;
                GL.Ortho(0.0, 30.0 * (float)AnT.Width / AnT.Height, 0.0, 30.0, -1, 1);
            }
            devX = (float)ScreenH / (float)AnT.Width;
            devY = (float)ScreenW / (float)AnT.Height;
            GL.MatrixMode(MatrixMode.Modelview);
            PointInGrap.Start();

        }
        
        private void PointInGrap_Tick(object sender, EventArgs e)
        {
            if (pointPosition == elements_count - 1)
            {
                pointPosition = 0;
            }
            Draw();
            pointPosition++;
        }
        
    }
}