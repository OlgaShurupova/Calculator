namespace Сalculator
{
    partial class MainWin
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWin));
            this.showResult = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grads = new System.Windows.Forms.RadioButton();
            this.radians = new System.Windows.Forms.RadioButton();
            this.degrees = new System.Windows.Forms.RadioButton();
            this.ClearMemory = new System.Windows.Forms.Button();
            this.ReadFromMemory = new System.Windows.Forms.Button();
            this.SaveToMemory = new System.Windows.Forms.Button();
            this.AddToMemory = new System.Windows.Forms.Button();
            this.SubtractFromMemory = new System.Windows.Forms.Button();
            this.GetPercentages = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.CE = new System.Windows.Forms.Button();
            this.Backspace = new System.Windows.Forms.Button();
            this.GetBackwardFraction = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.Subtract = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.resultButton = new System.Windows.Forms.Button();
            this.rightBracket = new System.Windows.Forms.Button();
            this.leftBracket = new System.Windows.Forms.Button();
            this.GetNaturalLogarithm = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.GetFactorial = new System.Windows.Forms.Button();
            this.GetSquare = new System.Windows.Forms.Button();
            this.GetRoot = new System.Windows.Forms.Button();
            this.GetPower = new System.Windows.Forms.Button();
            this.Dms = new System.Windows.Forms.Button();
            this.GetCubeRoot = new System.Windows.Forms.Button();
            this.GetCube = new System.Windows.Forms.Button();
            this.GetSquareRoot = new System.Windows.Forms.Button();
            this.button44 = new System.Windows.Forms.Button();
            this.button45 = new System.Windows.Forms.Button();
            this.button46 = new System.Windows.Forms.Button();
            this.GetTenPower = new System.Windows.Forms.Button();
            this.GetDecimalLogarithm = new System.Windows.Forms.Button();
            this.GetModule = new System.Windows.Forms.Button();
            this.Exp = new System.Windows.Forms.Button();
            this.ChangeFormat = new System.Windows.Forms.Button();
            this.PlusMinus = new System.Windows.Forms.Button();
            this.GetPi = new System.Windows.Forms.Button();
            this.GetTan = new System.Windows.Forms.Button();
            this.GetTanh = new System.Windows.Forms.Button();
            this.GetCos = new System.Windows.Forms.Button();
            this.GetSin = new System.Windows.Forms.Button();
            this.GetSinh = new System.Windows.Forms.Button();
            this.GetInt = new System.Windows.Forms.Button();
            this.GetCosh = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showError = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // showResult
            // 
            this.showResult.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.showResult, "showResult");
            this.showResult.Name = "showResult";
            this.showResult.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ShowResultKeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grads);
            this.groupBox1.Controls.Add(this.radians);
            this.groupBox1.Controls.Add(this.degrees);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // grads
            // 
            resources.ApplyResources(this.grads, "grads");
            this.grads.Name = "grads";
            this.grads.TabStop = true;
            this.grads.UseVisualStyleBackColor = true;
            // 
            // radians
            // 
            resources.ApplyResources(this.radians, "radians");
            this.radians.Checked = true;
            this.radians.Name = "radians";
            this.radians.TabStop = true;
            this.radians.UseVisualStyleBackColor = true;
            // 
            // degrees
            // 
            resources.ApplyResources(this.degrees, "degrees");
            this.degrees.Name = "degrees";
            this.degrees.TabStop = true;
            this.degrees.UseVisualStyleBackColor = true;
            // 
            // ClearMemory
            // 
            resources.ApplyResources(this.ClearMemory, "ClearMemory");
            this.ClearMemory.Name = "ClearMemory";
            this.ClearMemory.UseVisualStyleBackColor = true;
            this.ClearMemory.Click += new System.EventHandler(this.MemoryClick);
            // 
            // ReadFromMemory
            // 
            resources.ApplyResources(this.ReadFromMemory, "ReadFromMemory");
            this.ReadFromMemory.Name = "ReadFromMemory";
            this.ReadFromMemory.UseVisualStyleBackColor = true;
            this.ReadFromMemory.Click += new System.EventHandler(this.ReadMemoryClick);
            // 
            // SaveToMemory
            // 
            resources.ApplyResources(this.SaveToMemory, "SaveToMemory");
            this.SaveToMemory.Name = "SaveToMemory";
            this.SaveToMemory.UseVisualStyleBackColor = true;
            this.SaveToMemory.Click += new System.EventHandler(this.MemoryClick);
            // 
            // AddToMemory
            // 
            resources.ApplyResources(this.AddToMemory, "AddToMemory");
            this.AddToMemory.Name = "AddToMemory";
            this.AddToMemory.UseVisualStyleBackColor = true;
            this.AddToMemory.Click += new System.EventHandler(this.MemoryClick);
            // 
            // SubtractFromMemory
            // 
            resources.ApplyResources(this.SubtractFromMemory, "SubtractFromMemory");
            this.SubtractFromMemory.Name = "SubtractFromMemory";
            this.SubtractFromMemory.UseVisualStyleBackColor = true;
            this.SubtractFromMemory.Click += new System.EventHandler(this.MemoryClick);
            // 
            // GetPercentages
            // 
            resources.ApplyResources(this.GetPercentages, "GetPercentages");
            this.GetPercentages.Name = "GetPercentages";
            this.GetPercentages.UseVisualStyleBackColor = true;
            this.GetPercentages.Click += new System.EventHandler(this.AnySymbolButtonClick);
            // 
            // Divide
            // 
            resources.ApplyResources(this.Divide, "Divide");
            this.Divide.Name = "Divide";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.AnySymbolButtonClick);
            // 
            // button8
            // 
            resources.ApplyResources(this.button8, "button8");
            this.button8.Name = "button8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.ClearButtonClick);
            // 
            // CE
            // 
            resources.ApplyResources(this.CE, "CE");
            this.CE.Name = "CE";
            this.CE.UseVisualStyleBackColor = true;
            this.CE.Click += new System.EventHandler(this.ClearButtonClick);
            // 
            // Backspace
            // 
            resources.ApplyResources(this.Backspace, "Backspace");
            this.Backspace.Name = "Backspace";
            this.Backspace.UseVisualStyleBackColor = true;
            this.Backspace.Click += new System.EventHandler(this.BackspaceClick);
            // 
            // GetBackwardFraction
            // 
            resources.ApplyResources(this.GetBackwardFraction, "GetBackwardFraction");
            this.GetBackwardFraction.Name = "GetBackwardFraction";
            this.GetBackwardFraction.UseVisualStyleBackColor = true;
            this.GetBackwardFraction.Click += new System.EventHandler(this.AnySymbolButtonClick);
            // 
            // Multiply
            // 
            resources.ApplyResources(this.Multiply, "Multiply");
            this.Multiply.Name = "Multiply";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.AnySymbolButtonClick);
            // 
            // button13
            // 
            resources.ApplyResources(this.button13, "button13");
            this.button13.Name = "button13";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.AnySymbolButtonClick);
            // 
            // button14
            // 
            resources.ApplyResources(this.button14, "button14");
            this.button14.Name = "button14";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.AnySymbolButtonClick);
            // 
            // button15
            // 
            resources.ApplyResources(this.button15, "button15");
            this.button15.Name = "button15";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.AnySymbolButtonClick);
            // 
            // Subtract
            // 
            resources.ApplyResources(this.Subtract, "Subtract");
            this.Subtract.Name = "Subtract";
            this.Subtract.UseVisualStyleBackColor = true;
            this.Subtract.Click += new System.EventHandler(this.AnySymbolButtonClick);
            // 
            // button17
            // 
            resources.ApplyResources(this.button17, "button17");
            this.button17.Name = "button17";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.AnySymbolButtonClick);
            // 
            // button18
            // 
            resources.ApplyResources(this.button18, "button18");
            this.button18.Name = "button18";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.AnySymbolButtonClick);
            // 
            // button19
            // 
            resources.ApplyResources(this.button19, "button19");
            this.button19.Name = "button19";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.AnySymbolButtonClick);
            // 
            // Add
            // 
            resources.ApplyResources(this.Add, "Add");
            this.Add.Name = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.AnySymbolButtonClick);
            // 
            // button21
            // 
            resources.ApplyResources(this.button21, "button21");
            this.button21.Name = "button21";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.AnySymbolButtonClick);
            // 
            // button22
            // 
            resources.ApplyResources(this.button22, "button22");
            this.button22.Name = "button22";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.AnySymbolButtonClick);
            // 
            // resultButton
            // 
            this.resultButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            resources.ApplyResources(this.resultButton, "resultButton");
            this.resultButton.Name = "resultButton";
            this.resultButton.UseVisualStyleBackColor = true;
            this.resultButton.Click += new System.EventHandler(this.EqualsButtonClick);
            // 
            // rightBracket
            // 
            resources.ApplyResources(this.rightBracket, "rightBracket");
            this.rightBracket.Name = "rightBracket";
            this.rightBracket.UseVisualStyleBackColor = true;
            this.rightBracket.Click += new System.EventHandler(this.AnySymbolButtonClick);
            // 
            // leftBracket
            // 
            resources.ApplyResources(this.leftBracket, "leftBracket");
            this.leftBracket.Name = "leftBracket";
            this.leftBracket.UseVisualStyleBackColor = true;
            this.leftBracket.Click += new System.EventHandler(this.AnySymbolButtonClick);
            // 
            // GetNaturalLogarithm
            // 
            resources.ApplyResources(this.GetNaturalLogarithm, "GetNaturalLogarithm");
            this.GetNaturalLogarithm.Name = "GetNaturalLogarithm";
            this.GetNaturalLogarithm.UseVisualStyleBackColor = true;
            this.GetNaturalLogarithm.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // button27
            // 
            resources.ApplyResources(this.button27, "button27");
            this.button27.Name = "button27";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.InvertButtonClick);
            // 
            // GetFactorial
            // 
            resources.ApplyResources(this.GetFactorial, "GetFactorial");
            this.GetFactorial.Name = "GetFactorial";
            this.GetFactorial.UseVisualStyleBackColor = true;
            this.GetFactorial.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // GetSquare
            // 
            resources.ApplyResources(this.GetSquare, "GetSquare");
            this.GetSquare.Name = "GetSquare";
            this.GetSquare.UseVisualStyleBackColor = true;
            this.GetSquare.Click += new System.EventHandler(this.AnySymbolButtonClick);
            // 
            // GetRoot
            // 
            resources.ApplyResources(this.GetRoot, "GetRoot");
            this.GetRoot.Name = "GetRoot";
            this.GetRoot.UseVisualStyleBackColor = true;
            this.GetRoot.Click += new System.EventHandler(this.AnySymbolButtonClick);
            // 
            // GetPower
            // 
            resources.ApplyResources(this.GetPower, "GetPower");
            this.GetPower.Name = "GetPower";
            this.GetPower.UseVisualStyleBackColor = true;
            this.GetPower.Click += new System.EventHandler(this.AnySymbolButtonClick);
            // 
            // Dms
            // 
            resources.ApplyResources(this.Dms, "Dms");
            this.Dms.Name = "Dms";
            this.Dms.UseVisualStyleBackColor = true;
            this.Dms.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // GetCubeRoot
            // 
            resources.ApplyResources(this.GetCubeRoot, "GetCubeRoot");
            this.GetCubeRoot.Name = "GetCubeRoot";
            this.GetCubeRoot.UseVisualStyleBackColor = true;
            this.GetCubeRoot.Click += new System.EventHandler(this.AnySymbolButtonClick);
            // 
            // GetCube
            // 
            resources.ApplyResources(this.GetCube, "GetCube");
            this.GetCube.Name = "GetCube";
            this.GetCube.UseVisualStyleBackColor = true;
            this.GetCube.Click += new System.EventHandler(this.AnySymbolButtonClick);
            // 
            // GetSquareRoot
            // 
            resources.ApplyResources(this.GetSquareRoot, "GetSquareRoot");
            this.GetSquareRoot.Name = "GetSquareRoot";
            this.GetSquareRoot.UseVisualStyleBackColor = true;
            this.GetSquareRoot.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // button44
            // 
            resources.ApplyResources(this.button44, "button44");
            this.button44.Name = "button44";
            this.button44.UseVisualStyleBackColor = true;
            this.button44.Click += new System.EventHandler(this.AnySymbolButtonClick);
            // 
            // button45
            // 
            resources.ApplyResources(this.button45, "button45");
            this.button45.Name = "button45";
            this.button45.UseVisualStyleBackColor = true;
            this.button45.Click += new System.EventHandler(this.AnySymbolButtonClick);
            // 
            // button46
            // 
            resources.ApplyResources(this.button46, "button46");
            this.button46.Name = "button46";
            this.button46.UseVisualStyleBackColor = true;
            this.button46.Click += new System.EventHandler(this.AnySymbolButtonClick);
            // 
            // GetTenPower
            // 
            resources.ApplyResources(this.GetTenPower, "GetTenPower");
            this.GetTenPower.Name = "GetTenPower";
            this.GetTenPower.UseVisualStyleBackColor = true;
            this.GetTenPower.Click += new System.EventHandler(this.AnySymbolButtonClick);
            // 
            // GetDecimalLogarithm
            // 
            resources.ApplyResources(this.GetDecimalLogarithm, "GetDecimalLogarithm");
            this.GetDecimalLogarithm.Name = "GetDecimalLogarithm";
            this.GetDecimalLogarithm.UseVisualStyleBackColor = true;
            this.GetDecimalLogarithm.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // GetModule
            // 
            resources.ApplyResources(this.GetModule, "GetModule");
            this.GetModule.Name = "GetModule";
            this.GetModule.UseVisualStyleBackColor = true;
            this.GetModule.Click += new System.EventHandler(this.AnySymbolButtonClick);
            // 
            // Exp
            // 
            resources.ApplyResources(this.Exp, "Exp");
            this.Exp.Name = "Exp";
            this.Exp.UseVisualStyleBackColor = true;
            this.Exp.Click += new System.EventHandler(this.ExponentialFormatClick);
            // 
            // ChangeFormat
            // 
            resources.ApplyResources(this.ChangeFormat, "ChangeFormat");
            this.ChangeFormat.Name = "ChangeFormat";
            this.ChangeFormat.UseVisualStyleBackColor = true;
            this.ChangeFormat.Click += new System.EventHandler(this.ChangeFormatClickk);
            // 
            // PlusMinus
            // 
            resources.ApplyResources(this.PlusMinus, "PlusMinus");
            this.PlusMinus.Name = "PlusMinus";
            this.PlusMinus.UseVisualStyleBackColor = true;
            this.PlusMinus.Click += new System.EventHandler(this.PlusMinusClick);
            // 
            // GetPi
            // 
            resources.ApplyResources(this.GetPi, "GetPi");
            this.GetPi.Name = "GetPi";
            this.GetPi.UseVisualStyleBackColor = true;
            this.GetPi.Click += new System.EventHandler(this.PiClick);
            // 
            // GetTan
            // 
            resources.ApplyResources(this.GetTan, "GetTan");
            this.GetTan.Name = "GetTan";
            this.GetTan.UseVisualStyleBackColor = true;
            this.GetTan.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // GetTanh
            // 
            resources.ApplyResources(this.GetTanh, "GetTanh");
            this.GetTanh.Name = "GetTanh";
            this.GetTanh.UseVisualStyleBackColor = true;
            this.GetTanh.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // GetCos
            // 
            resources.ApplyResources(this.GetCos, "GetCos");
            this.GetCos.Name = "GetCos";
            this.GetCos.UseVisualStyleBackColor = true;
            this.GetCos.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // GetSin
            // 
            resources.ApplyResources(this.GetSin, "GetSin");
            this.GetSin.Name = "GetSin";
            this.GetSin.UseVisualStyleBackColor = true;
            this.GetSin.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // GetSinh
            // 
            resources.ApplyResources(this.GetSinh, "GetSinh");
            this.GetSinh.Name = "GetSinh";
            this.GetSinh.UseVisualStyleBackColor = true;
            this.GetSinh.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // GetInt
            // 
            resources.ApplyResources(this.GetInt, "GetInt");
            this.GetInt.Name = "GetInt";
            this.GetInt.UseVisualStyleBackColor = true;
            this.GetInt.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // GetCosh
            // 
            resources.ApplyResources(this.GetCosh, "GetCosh");
            this.GetCosh.Name = "GetCosh";
            this.GetCosh.UseVisualStyleBackColor = true;
            this.GetCosh.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // showError
            // 
            resources.ApplyResources(this.showError, "showError");
            this.showError.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.showError.Name = "showError";
            // 
            // MainWin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.showError);
            this.Controls.Add(this.PlusMinus);
            this.Controls.Add(this.GetTenPower);
            this.Controls.Add(this.GetDecimalLogarithm);
            this.Controls.Add(this.GetModule);
            this.Controls.Add(this.Exp);
            this.Controls.Add(this.ChangeFormat);
            this.Controls.Add(this.GetSquareRoot);
            this.Controls.Add(this.button44);
            this.Controls.Add(this.button45);
            this.Controls.Add(this.button46);
            this.Controls.Add(this.GetCubeRoot);
            this.Controls.Add(this.GetCube);
            this.Controls.Add(this.GetTan);
            this.Controls.Add(this.GetTanh);
            this.Controls.Add(this.GetPi);
            this.Controls.Add(this.GetRoot);
            this.Controls.Add(this.GetPower);
            this.Controls.Add(this.GetCos);
            this.Controls.Add(this.GetCosh);
            this.Controls.Add(this.Dms);
            this.Controls.Add(this.GetFactorial);
            this.Controls.Add(this.GetSquare);
            this.Controls.Add(this.GetSin);
            this.Controls.Add(this.GetSinh);
            this.Controls.Add(this.GetInt);
            this.Controls.Add(this.rightBracket);
            this.Controls.Add(this.leftBracket);
            this.Controls.Add(this.GetNaturalLogarithm);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.resultButton);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.Subtract);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.GetBackwardFraction);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.GetPercentages);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.CE);
            this.Controls.Add(this.Backspace);
            this.Controls.Add(this.SubtractFromMemory);
            this.Controls.Add(this.AddToMemory);
            this.Controls.Add(this.SaveToMemory);
            this.Controls.Add(this.ReadFromMemory);
            this.Controls.Add(this.ClearMemory);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.showResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainWin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox showResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton grads;
        private System.Windows.Forms.RadioButton radians;
        private System.Windows.Forms.RadioButton degrees;
        private System.Windows.Forms.Button ClearMemory;
        private System.Windows.Forms.Button ReadFromMemory;
        private System.Windows.Forms.Button SaveToMemory;
        private System.Windows.Forms.Button AddToMemory;
        private System.Windows.Forms.Button SubtractFromMemory;
        private System.Windows.Forms.Button GetPercentages;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button CE;
        private System.Windows.Forms.Button Backspace;
        private System.Windows.Forms.Button GetBackwardFraction;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button Subtract;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button resultButton;
        private System.Windows.Forms.Button rightBracket;
        private System.Windows.Forms.Button leftBracket;
        private System.Windows.Forms.Button GetNaturalLogarithm;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button GetFactorial;
        private System.Windows.Forms.Button GetSquare;
        private System.Windows.Forms.Button GetRoot;
        private System.Windows.Forms.Button GetPower;
        private System.Windows.Forms.Button Dms;
        private System.Windows.Forms.Button GetCubeRoot;
        private System.Windows.Forms.Button GetCube;
        private System.Windows.Forms.Button GetSquareRoot;
        private System.Windows.Forms.Button button44;
        private System.Windows.Forms.Button button45;
        private System.Windows.Forms.Button button46;
        private System.Windows.Forms.Button GetTenPower;
        private System.Windows.Forms.Button GetDecimalLogarithm;
        private System.Windows.Forms.Button GetModule;
        private System.Windows.Forms.Button Exp;
        private System.Windows.Forms.Button ChangeFormat;
        private System.Windows.Forms.Button PlusMinus;
        private System.Windows.Forms.Button GetPi;
        private System.Windows.Forms.Button GetTan;
        private System.Windows.Forms.Button GetTanh;
        private System.Windows.Forms.Button GetCos;
        private System.Windows.Forms.Button GetSin;
        private System.Windows.Forms.Button GetSinh;
        private System.Windows.Forms.Button GetInt;
        private System.Windows.Forms.Button GetCosh;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label showError;
    }
}

