using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;

namespace ExamenSB_U2
{
    public partial class Form1 : Form
    {
        //private string LenguajeNaturalPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"\\LenguajeNatural.txt";
		private string LenguajeNaturalPath = System.IO.Directory.GetCurrentDirectory() + "\\..\\..\\LenguajeNatural.txt";
		private string LenguajeTraducidoPath = System.IO.Directory.GetCurrentDirectory() + "\\..\\..\\LenguajeTraducido.txt";
        private string VBCompiler = "C:\\Windows\\Microsoft.NET\\Framework\\v4.0.30319\\vbc.exe";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(!File.Exists(LenguajeNaturalPath))
                using (File.Create(LenguajeNaturalPath))
            if (!File.Exists(LenguajeTraducidoPath))
                using (File.Create(LenguajeTraducidoPath))
            LenguajeNaturalLst.Items.Clear();
            var lines = File.ReadAllLines(LenguajeNaturalPath);
            int NL = 1;
            foreach (string line in lines)
            {
                LenguajeNaturalLst.Items.Add(new ListViewItem(new[] { NL.ToString(), line }));
                NL++;
            }
			//LenguajeNaturalLst.Items.Add(new ListViewItem(new[] { NL.ToString(), System.IO.Directory.GetCurrentDirectory() }));
		}

        private void AbrirBtn_Click(object sender, EventArgs e)
        {
            LenguajeNaturalLst.Items.Clear();
            var lines = File.ReadAllLines(LenguajeNaturalPath);
            int NL = 1;
            foreach (string line in lines)
            {
                LenguajeNaturalLst.Items.Add(new ListViewItem(new[] { NL.ToString(), line }));
                NL++;
            }
        }

        private void TraducirBtn_Click(object sender, EventArgs e)
        {
            VisualBasicLst.Items.Clear();
            lstErrores.Items.Clear();
            List<string> LN = LenguajeNaturalLst.Items.Cast<ListViewItem>()
                                 .Select(item => item.SubItems[1].Text)
                                 .ToList();
            List<string> TiposDato = new List<string> { "entero", "decimal", "cadena", "booleano", "caracter" };
            List<string> AccesoCF = new List<string> { "publica", "privada" };
            List<string> ClaseF = new List<string> { "clase" };
            List<string> Funciones = new List<string> { "imprimir", "leer", "mientras", "para", "si", "regresar", "hacer", "seleccion", "caso" };
            List<string> Especiales = new List<string> { "{", "}" };

            List<string> DataType = new List<string> { "Integer", "Decimal", "String", "Boolean", "Char" };
            List<string> AccessCF = new List<string> { "Public", "Private" };
            List<string> ClassF = new List<string> { "Module" };
            List<string> Funcion = new List<string> { "Console.WriteLine", "Console.ReadLine", "While", "For", "If", "Return", "Do While", "Select", "Case" };
            List<string> Specials = new List<string> { " ", "End" };

            Dictionary<string, string> Variables = new Dictionary<string, string>();
            List<string> Operadores = new List<string> { "+", "-", "*", "/", "%" };

            int Llaves = 0;
            List<string> Orden = new List<string>();
            int Numeracion = 0;

            foreach (string line in LN)
            {
                Numeracion++;
                bool Aumento = false;
                if (Especiales.Any(f => line.Contains(f))) // Llaves
                {
                    if (line.Contains(Especiales[0]))
                    {
                        Aumento = true;
                        if (Regex.Match(line, @"^\s*\{").Success)
                        {
                            LenguajeNaturalLst.Items[Numeracion - 2].SubItems[1].Text += " { ";
                            Llaves++;
                            continue;
                        }
                    }
                    else if (line.Contains(Especiales[1]))
                    {
                        if (Orden[Orden.Count - 1] == "")
                        {
                            Orden.RemoveAt(Orden.Count - 1);
                            Llaves--;
                        }
                        Llaves--;
                        VisualBasicLst.Items.Add(new ListViewItem(new[] { Numeracion.ToString(), $"{new string(' ', Llaves * 2)}{Orden.LastOrDefault()}" }));
                        if (Orden.Count > 0) Orden.RemoveAt(Orden.Count - 1);
                        continue;
                    }
                }
                if (AccesoCF.Any(f => line.Contains(f))) // Clases o funciones
                {
                    int AccessIndex = AccesoCF.Select((item, i) => line.Contains(item) ? i : -1).FirstOrDefault(i => i != -1);
                    if (ClaseF.Any(f => line.Contains(f))) // Clase
                    {
                        int ClassIndex = ClaseF.Select((item, i) => line.Contains(item) ? i : -1).FirstOrDefault(i => i != -1);
                        VisualBasicLst.Items.Add(new ListViewItem(new[] { Numeracion.ToString(), $"{new string(' ', Llaves * 2)}{AccessCF[AccessIndex]} {ClassF[ClassIndex]} {line.TrimStart().Split(' ')[2]}" }));
                        Orden.Add($"{Specials[1]} Module");
                    }
                    else
                    {
                        string Traducido = Regex.Match(line, @"\((.*?)\)").Groups[1].Value != ""
                                                                                ? Regex.Match(line, @"\((.*?)\)").Groups[1].Value
                                                                                    .Split(',')
                                                                                    .Select(item => $"ByVal {item.Split(' ')[1]} as {DataType[TiposDato.IndexOf(item.Split(' ')[0])]}")
                                                                                    .Aggregate((acc, next) => acc + next)
                                                                                : "";
                        if (TiposDato.Any(f => line.Contains(f))) // Funcion con retorno
                        {
                            int DatoIndex = TiposDato.Select((item, i) => line.Contains(item) ? i : -1).FirstOrDefault(i => i != -1);
                            VisualBasicLst.Items.Add(new ListViewItem(new[] { Numeracion.ToString(), $"{new string(' ', Llaves * 2)}{AccessCF[AccessIndex]} Function {line.TrimStart().Split(' ')[2]}({Traducido}) as {DataType[DatoIndex]} " }));
                            Orden.Add($"{Specials[1]} Function");
                        }
                        else // Funcion sin retorno
                        {
                            VisualBasicLst.Items.Add(new ListViewItem(new[] { Numeracion.ToString(), $"{new string(' ', Llaves * 2)}{AccessCF[AccessIndex]} Sub {line.TrimStart().Split(' ')[1]} " }));
                            Orden.Add($"{Specials[1]} Sub");
                        }

                    }
                }
                else if (Funciones.Any(f => line.Contains(f))) // Encuentra una funcion
                {
                    int FuncionIndex = Funciones.Select((item, i) => line.Contains(item) ? i : -1).FirstOrDefault(i => i != -1);
                    if (FuncionIndex == 0 || FuncionIndex == 1) // Write line || Read line
                    {
                        VisualBasicLst.Items.Add(new ListViewItem(new[] { Numeracion.ToString(), $"{new string(' ', Llaves * 2)}{Funcion[FuncionIndex]}({Regex.Match(line, @"\((.*?)\)").Groups[1].Value})" }));
                    }
                    else if (FuncionIndex == 2) // While
                    {
                        VisualBasicLst.Items.Add(new ListViewItem(new[] { Numeracion.ToString(), $"{new string(' ', Llaves * 2)}{Funcion[FuncionIndex]} {Regex.Match(line, @"\((.*?)\)").Groups[1].Value}" }));
                        Orden.Add($"{Specials[1]} While");
                    }
                    else if (FuncionIndex == 3) // For
                    {
                        string[] DivisionesFor = (Regex.Match(line, @"\((.*?)\)").Groups[1].Value).Split(';');
                        if (DivisionesFor[1].Contains('='))
                            VisualBasicLst.Items.Add(new ListViewItem(new[] { Numeracion.ToString(), $"{new string(' ', Llaves * 2)}{Funcion[FuncionIndex]} {DivisionesFor[0]} To {Regex.Match(DivisionesFor[1], "[<>\\=]+(.+)$").Groups[1].Value.Trim()}" }));
                        else
                        {
                            if (DivisionesFor[2].Contains("++"))
                                VisualBasicLst.Items.Add(new ListViewItem(new[] { Numeracion.ToString(), $"{new string(' ', Llaves * 2)}{Funcion[FuncionIndex]} {DivisionesFor[0]} To {Regex.Match(DivisionesFor[1], "[<>\\=]+(.+)$").Groups[1].Value.Trim()} - 1" }));
                            else
                                VisualBasicLst.Items.Add(new ListViewItem(new[] { Numeracion.ToString(), $"{new string(' ', Llaves * 2)}{Funcion[FuncionIndex]} {DivisionesFor[0]} To {Regex.Match(DivisionesFor[1], "[<>\\=]+(.+)$").Groups[1].Value.Trim()} - 1" }));
                        }
                        Orden.Add("Next");
                    }
                    else if (FuncionIndex == 4) // If
                    {
                        VisualBasicLst.Items.Add(new ListViewItem(new[] { Numeracion.ToString(), $"{new string(' ', Llaves * 2)}{Funcion[FuncionIndex]} {Regex.Match(line, @"\((.*?)\)").Groups[1].Value} Then" }));
                        Orden.Add($"{Specials[1]} If");
                    }
                    else if (FuncionIndex == 5) // Return
                    {
                        VisualBasicLst.Items.Add(new ListViewItem(new[] { Numeracion.ToString(), $"{new string(' ', Llaves * 2)}{Funcion[FuncionIndex]} {string.Join(" ", line.TrimStart().Split(' ').Skip(1))}" }));
                    }
                    else if (FuncionIndex == 6) // Do While
                    {
                        VisualBasicLst.Items.Add(new ListViewItem(new[] { Numeracion.ToString(), $"{new string(' ', Llaves * 2)}{Funcion[FuncionIndex]} {Regex.Match(line, @"\((.*?)\)").Groups[1].Value}" }));
                        Orden.Add($"Loop");
                    }
                    else if (FuncionIndex == 7) // Switch
                    {
                        VisualBasicLst.Items.Add(new ListViewItem(new[] { Numeracion.ToString(), $"{new string(' ', Llaves * 2)}{Funcion[FuncionIndex]} {Regex.Match(line, @"\((.*?)\)").Groups[1].Value}" }));
                        Orden.Add($"{Specials[1]} Select");
                    }
                    else if (FuncionIndex == 8) // Case
                    {
                        if (Orden[Orden.Count - 1].ToString() == "")
                            Llaves--;
                        VisualBasicLst.Items.Add(new ListViewItem(new[] { Numeracion.ToString(), $"{new string(' ', Llaves * 2)}{Funcion[FuncionIndex]} {Regex.Match(line, @"\((.*?)\)").Groups[1].Value}" }));
                        if (Orden[Orden.Count - 1].ToString() != "")
                        {
                            Orden.Add($"");
                        }
                        Llaves++;
                    }
                }
                else if (TiposDato.Any(f => line.Contains(f))) // Declarar var
                {
                    if (Variables.ContainsKey(line.TrimStart().Split(' ')[1])) // Variable ya declarada
                    {
                        ErrorEnLinea(Numeracion, line, $"; Variable '{line.TrimStart().Split(' ')[1]}' ya declarada, error semantico.");
                        continue;
                    }
                    int DatoIndex = TiposDato.Select((item, i) => line.Contains(item) ? i : -1).FirstOrDefault(i => i != -1);
                    if (line.Contains('=')) // Asignacion
                        VisualBasicLst.Items.Add(new ListViewItem(new[] { Numeracion.ToString(), $"{new string(' ', Llaves * 2)}Dim {line.TrimStart().Split(' ')[1]} As {DataType[DatoIndex]} = {string.Join(" ", line.TrimStart().Split(' ').Skip(3))}" }));
                    else // Declaracion
                        VisualBasicLst.Items.Add(new ListViewItem(new[] { Numeracion.ToString(), $"{new string(' ', Llaves * 2)}Dim {line.TrimStart().Split(' ')[1]} As {DataType[DatoIndex]}" }));
                    Variables.Add(line.TrimStart().Split(' ')[1], line.TrimStart().Split(' ')[0]); // Agregar variable a la lista
                }
                else if (Variables.Keys.Any(f => line.TrimStart().Split(' ')[0].Contains(f))) // Manipulacion de variables
                {
                    if (line.TrimStart().Split(' ')[1] == "=") {
                        string matchingKey = Variables
                                                .Where(kv => line.TrimStart().Split('=')[1].Contains(kv.Key))
                                                .Select(kv => kv.Value)
                                                .FirstOrDefault();
                        string matchingKeyAssign = Variables
                                                .Where(kv => line.TrimStart().Split('=')[0].Contains(kv.Key))
                                                .Select(kv => kv.Value)
                                                .FirstOrDefault();
                        string LastIndex = line.TrimStart().Split(' ')[line.TrimStart().Split(' ').Length - 1];
                        if (LastIndex == "+" || LastIndex == "-" || LastIndex == "*" || LastIndex == "/" || LastIndex == "=")
                        {
                            ErrorEnLinea(Numeracion, line, $"; Faltan parametros a la expresion '{line.TrimStart()}', error sintactico.");
                        }
                        else if (matchingKey != matchingKeyAssign) // Variable a asignar no es el mismo tipo
                        {
                            ErrorEnLinea(Numeracion, line, $"; Variable '{line.TrimStart().Split('=')[0]}' no se puede asignar si no es del mismo tipo de dato, error semantico.");
                        }
                        else {
                            VisualBasicLst.Items.Add(new ListViewItem(new[] { Numeracion.ToString(), $"{new string(' ', Llaves * 2)}{line.TrimStart()}" }));
                        }
                    }
                }
                else if (line == "") // Linea vacias
                    VisualBasicLst.Items.Add(new ListViewItem(new[] { Numeracion.ToString(), line }));
                else // No se puede traducir la linea
                {
                    VisualBasicLst.Items.Add(new ListViewItem(new[] { Numeracion.ToString(), line }));
                    VisualBasicLst.Items[VisualBasicLst.Items.Count - 1].ForeColor = Color.Red;
                    LineasNTraducidasLb.Text = (int.Parse(LineasNTraducidasLb.Text) + 1).ToString();
                    lstErrores.Items.Add(new ListViewItem(new[] { Numeracion.ToString(), $"Error line: {line}; Linea no se puede traducir, error lexico." }));
                }
                if (line.Contains("(") && !line.Contains(")") || line.Contains(")") && !line.Contains("(")) // Faltan parentesis
                {
                    lstErrores.Items.Add(new ListViewItem(new[] { Numeracion.ToString(), $"Error linea : {line} ; Falta parentesis, error sintactico." }));
                    VisualBasicLst.Items[VisualBasicLst.Items.Count - 1].ForeColor = Color.Red;
                    LineasNTraducidasLb.Text = (int.Parse(LineasNTraducidasLb.Text) + 1).ToString();
                }
                if (Aumento) Llaves++; 
            }
            LenguajeNaturalLst.Items.Cast<ListViewItem>()
                                            .Where(item => Regex.IsMatch(item.SubItems[1].Text, @"^\s*\{"))
                                            .ToList()
                                            .ForEach(item => LenguajeNaturalLst.Items.Remove(item)); // Quitar lineas con llaves de entrada solas {
            LineasTraducidasLbl.Text = (Numeracion - int.Parse(LineasNTraducidasLb.Text)).ToString(); // Cantidad de lineas traducidas

            try // Escribir en txt
            {
                using (StreamWriter writer = new StreamWriter(LenguajeTraducidoPath))
                {
                    List<string> VB = VisualBasicLst.Items.Cast<ListViewItem>()
                                 .Select(item => item.SubItems[1].Text)
                                 .ToList();
                    foreach (var item in VB)
                    {
                        writer.WriteLine(string.Join("\t", item));
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        public void ErrorEnLinea(int Numeracion, string Linea, string TxtError = "") // Marcar en rojo error
        {
            VisualBasicLst.Items.Add(new ListViewItem(new[] { Numeracion.ToString(), Linea }));
            VisualBasicLst.Items[VisualBasicLst.Items.Count - 1].ForeColor = Color.Red;
            LineasNTraducidasLb.Text = (int.Parse(LineasNTraducidasLb.Text) + 1).ToString();
            lstErrores.Items.Add(new ListViewItem(new[] { Numeracion.ToString(), $"Error linea: {Linea} {TxtError}" }));
        }

        private void LenguajeNaturalLst_SelectedIndexChanged(object sender, EventArgs e)
        {
            VisualBasicLst.Items.Cast<ListViewItem>().ToList().ForEach(item => { item.Selected = false; item.BackColor = Color.White; });
            LenguajeNaturalLst.Items.Cast<ListViewItem>().Where(item => item.Selected).ToList().ForEach(item => { int Index = item.Index; if (VisualBasicLst.Items.Count > Index) VisualBasicLst.Items[Index].BackColor = Color.Yellow; });
        }

        private void VisualBasicLst_SelectedIndexChanged(object sender, EventArgs e)
        {
            LenguajeNaturalLst.Items.Cast<ListViewItem>().ToList().ForEach(item => { item.Selected = false; item.BackColor = Color.White; });
            VisualBasicLst.Items.Cast<ListViewItem>().Where(item => item.Selected).ToList().ForEach(item => { int Index = item.Index; if (LenguajeNaturalLst.Items.Count > Index) LenguajeNaturalLst.Items[Index].BackColor = Color.Yellow; });
        }

        private void lenguajeNaturalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", LenguajeNaturalPath);
        }

        private void lenguajeTraducidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", LenguajeTraducidoPath);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int NL = 1;
            LenguajeNaturalLst.Items.Clear();
            string[] HelloWorld = new string[] {"clase publica HelloWorld {", " publica Main() {", "  imprimir(\"Hello world\")", " }", "}" };
            foreach (string HelloWorldItem in HelloWorld)
            {
                LenguajeNaturalLst.Items.Add(new ListViewItem(new[] { NL.ToString(), HelloWorldItem }));
                NL++;
            }
                
        }

        private void declararVariableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int NL = 1;
            LenguajeNaturalLst.Items.Clear();
            string[] Variable = new string[] { "clase publica DeclararVar {", " publica Main() {", "  entero Var1", "  decimal Var2 = 5.0", "  cadena Str1 = \"Hello World\"", "  booleano Boo1 = true", " }", "}" };
            foreach (string VariableItem in Variable)
            {
                LenguajeNaturalLst.Items.Add(new ListViewItem(new[] { NL.ToString(), VariableItem }));
                NL++;
            }
        }

        private void forToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int NL = 1;
            LenguajeNaturalLst.Items.Clear();
            string[] ForLoop = new string[] { "clase publica ForLoop {", " publica Main() {", "  entero Var1 = 0", "  para(Var1 = 0; Var1 < 10; Var1++) {", "   imprimir(\"Hello World\"&Var1)", "  }", " }", "}" };
            foreach (string ForLoopItem in ForLoop)
            {
                LenguajeNaturalLst.Items.Add(new ListViewItem(new[] { NL.ToString(), ForLoopItem }));
                NL++;
            }
        }

        private void whileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int NL = 1;
            LenguajeNaturalLst.Items.Clear();
            string[] WhileLoop = new string[] { "clase publica WhileLoop {", " publica Main() {", "  entero Var1 = 0", "  mientras(Var1 < 10) {", "   imprimir(Var1)", "   Var1 += 1", "  }", " }", "}" };
            foreach (string WhileItem in WhileLoop)
            {
                LenguajeNaturalLst.Items.Add(new ListViewItem(new[] { NL.ToString(), WhileItem }));
                NL++;
            }
        }

        private void ifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int NL = 1;
            LenguajeNaturalLst.Items.Clear();
            string[] IfC = new string[] { "clase publica IfCondicion {", " publica Main() {", "  entero Var1 = 10", "  si(Var1 < 10) {", "   imprimir(Var1)", "  }", " }", "}" };
            foreach (string IfItem in IfC)
            {
                LenguajeNaturalLst.Items.Add(new ListViewItem(new[] { NL.ToString(), IfItem }));
                NL++;
            }
        }

        private void numeroAlCuadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int NL = 1;
            LenguajeNaturalLst.Items.Clear();
            string[] Exponente = new string[] { "clase publica ForLoop {", " publica Main() {", "  entero NumeroPotencia", "  NumeroPotencia = Exp(5)", "   imprimir(NumeroPotencia)", " }", " publica entero Exp (entero N) {", "  regresar N * N", " }", "}" };
            foreach (string ExponenteItem in Exponente)
            {
                LenguajeNaturalLst.Items.Add(new ListViewItem(new[] { NL.ToString(), ExponenteItem }));
                NL++;
            }
        }

        private void lstErrores_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

		private void compilatBtn_Click(object sender, EventArgs e)
		{
            if(VisualBasicLst.Items.Count > 0 && lstErrores.Items.Count == 0)
            {
				ProcessStartInfo ProcessInfo;
				Process Process;

				ProcessInfo = new ProcessStartInfo("cmd.exe", $"/k \"cd /d {System.IO.Directory.GetCurrentDirectory()}\\..\\..\\ && {VBCompiler} LenguajeTraducido.txt && LenguajeTraducido.exe\"");
				ProcessInfo.CreateNoWindow = true;
				ProcessInfo.UseShellExecute = true;

				Process = Process.Start(ProcessInfo);
			}
		}

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Leal Cortez David Alejandro\nUniversidad Autonoma de Tamaulipas\nUnidad multidisiplinaria Reynosa-Rodhe\nProgramacion de Sistemas de Base II\n9no Semestre");
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string filePath = @"C:\Users\PC\Desktop\Ayuda.docx";

            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "WINWORD.EXE", // El ejecutable de Word
                Arguments = filePath,     // La ruta de tu archivo de Word
            };
            Process.Start(startInfo);
        }
    }
}
