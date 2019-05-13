namespace JavaTestCenter
{
    partial class JavaTestCenter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JavaTestCenter));
            this.TextBox_Process = new System.Windows.Forms.TextBox();
            this.Label_Process = new System.Windows.Forms.Label();
            this.GroupBox_Initialize = new System.Windows.Forms.GroupBox();
            this.RadioButton_None = new System.Windows.Forms.RadioButton();
            this.RadioButton_D = new System.Windows.Forms.RadioButton();
            this.RadioButton_CP = new System.Windows.Forms.RadioButton();
            this.TextBox_Directory = new System.Windows.Forms.TextBox();
            this.Label_Directory = new System.Windows.Forms.Label();
            this.Button_JavaFile = new System.Windows.Forms.Button();
            this.TextBox_JavaFile = new System.Windows.Forms.TextBox();
            this.Label_JavaFile = new System.Windows.Forms.Label();
            this.Label_Arguments = new System.Windows.Forms.Label();
            this.GroupBox_Run = new System.Windows.Forms.GroupBox();
            this.Button_Run = new System.Windows.Forms.Button();
            this.GroupBox_Input = new System.Windows.Forms.GroupBox();
            this.Button_Input = new System.Windows.Forms.Button();
            this.TextBox_Input = new System.Windows.Forms.TextBox();
            this.Label_ExpInput = new System.Windows.Forms.Label();
            this.GroupBox_Output = new System.Windows.Forms.GroupBox();
            this.Button_Output = new System.Windows.Forms.Button();
            this.TextBox_Output = new System.Windows.Forms.TextBox();
            this.Label_ExpOutput = new System.Windows.Forms.Label();
            this.GroupBox_OutputActual = new System.Windows.Forms.GroupBox();
            this.TextBox_OutputActual = new System.Windows.Forms.TextBox();
            this.GroupBox_Information = new System.Windows.Forms.GroupBox();
            this.TextBox_Information = new System.Windows.Forms.TextBox();
            this.GroupBox_Initialize.SuspendLayout();
            this.GroupBox_Run.SuspendLayout();
            this.GroupBox_Input.SuspendLayout();
            this.GroupBox_Output.SuspendLayout();
            this.GroupBox_OutputActual.SuspendLayout();
            this.GroupBox_Information.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox_Process
            // 
            this.TextBox_Process.Location = new System.Drawing.Point(212, 37);
            this.TextBox_Process.Multiline = true;
            this.TextBox_Process.Name = "TextBox_Process";
            this.TextBox_Process.ReadOnly = true;
            this.TextBox_Process.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox_Process.Size = new System.Drawing.Size(422, 93);
            this.TextBox_Process.TabIndex = 13;
            // 
            // Label_Process
            // 
            this.Label_Process.AutoSize = true;
            this.Label_Process.Location = new System.Drawing.Point(107, 40);
            this.Label_Process.Name = "Label_Process";
            this.Label_Process.Size = new System.Drawing.Size(89, 25);
            this.Label_Process.TabIndex = 98;
            this.Label_Process.Text = "Process:";
            // 
            // GroupBox_Initialize
            // 
            this.GroupBox_Initialize.Controls.Add(this.RadioButton_None);
            this.GroupBox_Initialize.Controls.Add(this.RadioButton_D);
            this.GroupBox_Initialize.Controls.Add(this.RadioButton_CP);
            this.GroupBox_Initialize.Controls.Add(this.TextBox_Directory);
            this.GroupBox_Initialize.Controls.Add(this.Label_Directory);
            this.GroupBox_Initialize.Controls.Add(this.Button_JavaFile);
            this.GroupBox_Initialize.Controls.Add(this.TextBox_JavaFile);
            this.GroupBox_Initialize.Controls.Add(this.Label_JavaFile);
            this.GroupBox_Initialize.Controls.Add(this.Label_Arguments);
            this.GroupBox_Initialize.Location = new System.Drawing.Point(13, 142);
            this.GroupBox_Initialize.Name = "GroupBox_Initialize";
            this.GroupBox_Initialize.Size = new System.Drawing.Size(897, 191);
            this.GroupBox_Initialize.TabIndex = 0;
            this.GroupBox_Initialize.TabStop = false;
            this.GroupBox_Initialize.Text = "Initialize";
            // 
            // RadioButton_None
            // 
            this.RadioButton_None.AutoSize = true;
            this.RadioButton_None.Location = new System.Drawing.Point(296, 145);
            this.RadioButton_None.Name = "RadioButton_None";
            this.RadioButton_None.Size = new System.Drawing.Size(84, 29);
            this.RadioButton_None.TabIndex = 103;
            this.RadioButton_None.Text = "None";
            this.RadioButton_None.UseVisualStyleBackColor = true;
            // 
            // RadioButton_D
            // 
            this.RadioButton_D.AutoSize = true;
            this.RadioButton_D.Location = new System.Drawing.Point(221, 145);
            this.RadioButton_D.Name = "RadioButton_D";
            this.RadioButton_D.Size = new System.Drawing.Size(55, 29);
            this.RadioButton_D.TabIndex = 102;
            this.RadioButton_D.Text = "-d";
            this.RadioButton_D.UseVisualStyleBackColor = true;
            // 
            // RadioButton_CP
            // 
            this.RadioButton_CP.AutoSize = true;
            this.RadioButton_CP.Checked = true;
            this.RadioButton_CP.Location = new System.Drawing.Point(141, 145);
            this.RadioButton_CP.Name = "RadioButton_CP";
            this.RadioButton_CP.Size = new System.Drawing.Size(65, 29);
            this.RadioButton_CP.TabIndex = 101;
            this.RadioButton_CP.TabStop = true;
            this.RadioButton_CP.Text = "-cp";
            this.RadioButton_CP.UseVisualStyleBackColor = true;
            // 
            // TextBox_Directory
            // 
            this.TextBox_Directory.Location = new System.Drawing.Point(141, 93);
            this.TextBox_Directory.Name = "TextBox_Directory";
            this.TextBox_Directory.ReadOnly = true;
            this.TextBox_Directory.Size = new System.Drawing.Size(600, 29);
            this.TextBox_Directory.TabIndex = 99;
            // 
            // Label_Directory
            // 
            this.Label_Directory.AutoSize = true;
            this.Label_Directory.Location = new System.Drawing.Point(22, 94);
            this.Label_Directory.Name = "Label_Directory";
            this.Label_Directory.Size = new System.Drawing.Size(95, 25);
            this.Label_Directory.TabIndex = 100;
            this.Label_Directory.Text = "Directory:";
            // 
            // Button_JavaFile
            // 
            this.Button_JavaFile.Location = new System.Drawing.Point(750, 36);
            this.Button_JavaFile.Margin = new System.Windows.Forms.Padding(6);
            this.Button_JavaFile.Name = "Button_JavaFile";
            this.Button_JavaFile.Size = new System.Drawing.Size(138, 42);
            this.Button_JavaFile.TabIndex = 97;
            this.Button_JavaFile.Text = "Browse";
            this.Button_JavaFile.UseVisualStyleBackColor = true;
            this.Button_JavaFile.Click += new System.EventHandler(this.Button_JavaFile_Click);
            // 
            // TextBox_JavaFile
            // 
            this.TextBox_JavaFile.Location = new System.Drawing.Point(141, 38);
            this.TextBox_JavaFile.Name = "TextBox_JavaFile";
            this.TextBox_JavaFile.ReadOnly = true;
            this.TextBox_JavaFile.Size = new System.Drawing.Size(600, 29);
            this.TextBox_JavaFile.TabIndex = 97;
            // 
            // Label_JavaFile
            // 
            this.Label_JavaFile.AutoSize = true;
            this.Label_JavaFile.Location = new System.Drawing.Point(22, 39);
            this.Label_JavaFile.Name = "Label_JavaFile";
            this.Label_JavaFile.Size = new System.Drawing.Size(97, 25);
            this.Label_JavaFile.TabIndex = 97;
            this.Label_JavaFile.Text = "Java File:";
            // 
            // Label_Arguments
            // 
            this.Label_Arguments.AutoSize = true;
            this.Label_Arguments.Location = new System.Drawing.Point(6, 145);
            this.Label_Arguments.Name = "Label_Arguments";
            this.Label_Arguments.Size = new System.Drawing.Size(113, 25);
            this.Label_Arguments.TabIndex = 95;
            this.Label_Arguments.Text = "Arguments:";
            // 
            // GroupBox_Run
            // 
            this.GroupBox_Run.Controls.Add(this.Button_Run);
            this.GroupBox_Run.Controls.Add(this.Label_Process);
            this.GroupBox_Run.Controls.Add(this.TextBox_Process);
            this.GroupBox_Run.Location = new System.Drawing.Point(13, 621);
            this.GroupBox_Run.Name = "GroupBox_Run";
            this.GroupBox_Run.Size = new System.Drawing.Size(897, 151);
            this.GroupBox_Run.TabIndex = 93;
            this.GroupBox_Run.TabStop = false;
            this.GroupBox_Run.Text = "Run";
            // 
            // Button_Run
            // 
            this.Button_Run.Location = new System.Drawing.Point(643, 62);
            this.Button_Run.Margin = new System.Windows.Forms.Padding(6);
            this.Button_Run.Name = "Button_Run";
            this.Button_Run.Size = new System.Drawing.Size(138, 42);
            this.Button_Run.TabIndex = 14;
            this.Button_Run.Text = "Run";
            this.Button_Run.UseVisualStyleBackColor = true;
            this.Button_Run.Click += new System.EventHandler(this.Button_Run_Click);
            // 
            // GroupBox_Input
            // 
            this.GroupBox_Input.Controls.Add(this.Button_Input);
            this.GroupBox_Input.Controls.Add(this.TextBox_Input);
            this.GroupBox_Input.Controls.Add(this.Label_ExpInput);
            this.GroupBox_Input.Location = new System.Drawing.Point(13, 339);
            this.GroupBox_Input.Name = "GroupBox_Input";
            this.GroupBox_Input.Size = new System.Drawing.Size(262, 276);
            this.GroupBox_Input.TabIndex = 90;
            this.GroupBox_Input.TabStop = false;
            this.GroupBox_Input.Text = "Input";
            // 
            // Button_Input
            // 
            this.Button_Input.Location = new System.Drawing.Point(131, 27);
            this.Button_Input.Margin = new System.Windows.Forms.Padding(6);
            this.Button_Input.Name = "Button_Input";
            this.Button_Input.Size = new System.Drawing.Size(121, 42);
            this.Button_Input.TabIndex = 8;
            this.Button_Input.Text = "Browse";
            this.Button_Input.UseVisualStyleBackColor = true;
            this.Button_Input.Click += new System.EventHandler(this.Button_Input_Click);
            // 
            // TextBox_Input
            // 
            this.TextBox_Input.Location = new System.Drawing.Point(11, 78);
            this.TextBox_Input.Multiline = true;
            this.TextBox_Input.Name = "TextBox_Input";
            this.TextBox_Input.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox_Input.Size = new System.Drawing.Size(241, 187);
            this.TextBox_Input.TabIndex = 9;
            // 
            // Label_ExpInput
            // 
            this.Label_ExpInput.AutoSize = true;
            this.Label_ExpInput.Location = new System.Drawing.Point(6, 36);
            this.Label_ExpInput.Name = "Label_ExpInput";
            this.Label_ExpInput.Size = new System.Drawing.Size(100, 25);
            this.Label_ExpInput.TabIndex = 96;
            this.Label_ExpInput.Text = "Exp Input:";
            // 
            // GroupBox_Output
            // 
            this.GroupBox_Output.Controls.Add(this.Button_Output);
            this.GroupBox_Output.Controls.Add(this.TextBox_Output);
            this.GroupBox_Output.Controls.Add(this.Label_ExpOutput);
            this.GroupBox_Output.Location = new System.Drawing.Point(281, 339);
            this.GroupBox_Output.Name = "GroupBox_Output";
            this.GroupBox_Output.Size = new System.Drawing.Size(262, 276);
            this.GroupBox_Output.TabIndex = 91;
            this.GroupBox_Output.TabStop = false;
            this.GroupBox_Output.Text = "Output";
            // 
            // Button_Output
            // 
            this.Button_Output.Location = new System.Drawing.Point(131, 27);
            this.Button_Output.Margin = new System.Windows.Forms.Padding(6);
            this.Button_Output.Name = "Button_Output";
            this.Button_Output.Size = new System.Drawing.Size(121, 42);
            this.Button_Output.TabIndex = 10;
            this.Button_Output.Text = "Browse";
            this.Button_Output.UseVisualStyleBackColor = true;
            this.Button_Output.Click += new System.EventHandler(this.Button_Output_Click);
            // 
            // TextBox_Output
            // 
            this.TextBox_Output.Location = new System.Drawing.Point(11, 78);
            this.TextBox_Output.Multiline = true;
            this.TextBox_Output.Name = "TextBox_Output";
            this.TextBox_Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox_Output.Size = new System.Drawing.Size(241, 187);
            this.TextBox_Output.TabIndex = 11;
            // 
            // Label_ExpOutput
            // 
            this.Label_ExpOutput.AutoSize = true;
            this.Label_ExpOutput.Location = new System.Drawing.Point(6, 36);
            this.Label_ExpOutput.Name = "Label_ExpOutput";
            this.Label_ExpOutput.Size = new System.Drawing.Size(116, 25);
            this.Label_ExpOutput.TabIndex = 97;
            this.Label_ExpOutput.Text = "Exp Output:";
            // 
            // GroupBox_OutputActual
            // 
            this.GroupBox_OutputActual.Controls.Add(this.TextBox_OutputActual);
            this.GroupBox_OutputActual.Location = new System.Drawing.Point(550, 339);
            this.GroupBox_OutputActual.Name = "GroupBox_OutputActual";
            this.GroupBox_OutputActual.Size = new System.Drawing.Size(360, 276);
            this.GroupBox_OutputActual.TabIndex = 92;
            this.GroupBox_OutputActual.TabStop = false;
            this.GroupBox_OutputActual.Text = "Output Actual";
            // 
            // TextBox_OutputActual
            // 
            this.TextBox_OutputActual.Location = new System.Drawing.Point(6, 28);
            this.TextBox_OutputActual.Multiline = true;
            this.TextBox_OutputActual.Name = "TextBox_OutputActual";
            this.TextBox_OutputActual.ReadOnly = true;
            this.TextBox_OutputActual.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox_OutputActual.Size = new System.Drawing.Size(348, 237);
            this.TextBox_OutputActual.TabIndex = 12;
            // 
            // GroupBox_Information
            // 
            this.GroupBox_Information.Controls.Add(this.TextBox_Information);
            this.GroupBox_Information.Location = new System.Drawing.Point(13, 13);
            this.GroupBox_Information.Name = "GroupBox_Information";
            this.GroupBox_Information.Size = new System.Drawing.Size(897, 123);
            this.GroupBox_Information.TabIndex = 94;
            this.GroupBox_Information.TabStop = false;
            this.GroupBox_Information.Text = "Information";
            // 
            // TextBox_Information
            // 
            this.TextBox_Information.Location = new System.Drawing.Point(6, 28);
            this.TextBox_Information.Multiline = true;
            this.TextBox_Information.Name = "TextBox_Information";
            this.TextBox_Information.ReadOnly = true;
            this.TextBox_Information.Size = new System.Drawing.Size(885, 82);
            this.TextBox_Information.TabIndex = 1;
            this.TextBox_Information.Text = resources.GetString("TextBox_Information.Text");
            // 
            // JavaTestCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 783);
            this.Controls.Add(this.GroupBox_Information);
            this.Controls.Add(this.GroupBox_OutputActual);
            this.Controls.Add(this.GroupBox_Output);
            this.Controls.Add(this.GroupBox_Input);
            this.Controls.Add(this.GroupBox_Run);
            this.Controls.Add(this.GroupBox_Initialize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JavaTestCenter";
            this.Text = "JavaTestCenter";
            this.GroupBox_Initialize.ResumeLayout(false);
            this.GroupBox_Initialize.PerformLayout();
            this.GroupBox_Run.ResumeLayout(false);
            this.GroupBox_Run.PerformLayout();
            this.GroupBox_Input.ResumeLayout(false);
            this.GroupBox_Input.PerformLayout();
            this.GroupBox_Output.ResumeLayout(false);
            this.GroupBox_Output.PerformLayout();
            this.GroupBox_OutputActual.ResumeLayout(false);
            this.GroupBox_OutputActual.PerformLayout();
            this.GroupBox_Information.ResumeLayout(false);
            this.GroupBox_Information.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox TextBox_Process;
        private System.Windows.Forms.Label Label_Process;
        private System.Windows.Forms.GroupBox GroupBox_Initialize;
        private System.Windows.Forms.GroupBox GroupBox_Run;
        private System.Windows.Forms.Button Button_Run;
        private System.Windows.Forms.GroupBox GroupBox_Input;
        private System.Windows.Forms.Button Button_Input;
        private System.Windows.Forms.TextBox TextBox_Input;
        private System.Windows.Forms.Label Label_ExpInput;
        private System.Windows.Forms.GroupBox GroupBox_Output;
        private System.Windows.Forms.Button Button_Output;
        private System.Windows.Forms.TextBox TextBox_Output;
        private System.Windows.Forms.GroupBox GroupBox_OutputActual;
        private System.Windows.Forms.TextBox TextBox_OutputActual;
        private System.Windows.Forms.Label Label_JavaFile;
        private System.Windows.Forms.GroupBox GroupBox_Information;
        private System.Windows.Forms.TextBox TextBox_Information;
        private System.Windows.Forms.Label Label_Arguments;
        private System.Windows.Forms.Button Button_JavaFile;
        private System.Windows.Forms.TextBox TextBox_JavaFile;
        private System.Windows.Forms.Label Label_ExpOutput;
        private System.Windows.Forms.TextBox TextBox_Directory;
        private System.Windows.Forms.Label Label_Directory;
        private System.Windows.Forms.RadioButton RadioButton_None;
        private System.Windows.Forms.RadioButton RadioButton_D;
        private System.Windows.Forms.RadioButton RadioButton_CP;
    }
}

