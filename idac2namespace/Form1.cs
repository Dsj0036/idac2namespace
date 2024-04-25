using System.Diagnostics;

namespace idac2namespace
{
    public partial class Form1 : Form
    {
        List<string> nspaces = new List<string>();
        List<function> functions = new List<function>();
        bool useDef;
        public struct function
        {

            public string name;
            public string segment;
            public uint startoffset;
            public uint length;
            public function(string[] tokens)
            {
                name = tokens[0].Replace("((", "(").Replace("))", ")");
                segment = tokens[1];
                startoffset = uint.Parse(tokens[2], System.Globalization.NumberStyles.HexNumber);
                length = uint.Parse(tokens[3], System.Globalization.NumberStyles.HexNumber);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateButtonClicked(object sender, EventArgs e)
        {
            var lines = this.richTextBox1.Text.Split('\n', '\r');
            foreach (var line in lines)
            {
                if (line.Contains(':'))
                {
                    string nspace = line.Split(':')[0];
                    if (!nspaces.Contains(nspace))
                    {
                        nspaces.Add(nspace);
                    }
                }
                var t = line.Split('\t');
                this.functions.Add(new function(t));

            }
            string code = string.Empty;

            foreach (string space in nspaces)
            {
                code += "namespace ";
                code += space;
                code += " {\n";

                foreach ()
                    code += "\t";
                code += "\n}";
            }
        }

        private void UseDefChanged(object sender, EventArgs e)
        {

        }
    }
}
