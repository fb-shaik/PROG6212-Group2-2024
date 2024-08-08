namespace ReflectionApp_WinForm_G2
{
    partial class frmReflection
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnDouble = new Button();
            btnTypes = new Button();
            btnAssemblies = new Button();
            btnString = new Button();
            btnArrayList = new Button();
            rtbTypes = new RichTextBox();
            rtbAssemblies = new RichTextBox();
            rtbArrayList = new RichTextBox();
            SuspendLayout();
            // 
            // btnDouble
            // 
            btnDouble.Location = new Point(238, 38);
            btnDouble.Name = "btnDouble";
            btnDouble.Size = new Size(146, 62);
            btnDouble.TabIndex = 0;
            btnDouble.Text = "Double";
            btnDouble.UseVisualStyleBackColor = true;
            btnDouble.Click += btnDouble_Click;
            // 
            // btnTypes
            // 
            btnTypes.Location = new Point(12, 148);
            btnTypes.Name = "btnTypes";
            btnTypes.Size = new Size(163, 105);
            btnTypes.TabIndex = 1;
            btnTypes.Text = "Types within the DLL";
            btnTypes.UseVisualStyleBackColor = true;
            btnTypes.Click += btnTypes_Click;
            // 
            // btnAssemblies
            // 
            btnAssemblies.Location = new Point(12, 322);
            btnAssemblies.Name = "btnAssemblies";
            btnAssemblies.Size = new Size(163, 101);
            btnAssemblies.TabIndex = 2;
            btnAssemblies.Text = "Assemblies within this app";
            btnAssemblies.UseVisualStyleBackColor = true;
            btnAssemblies.Click += btnAssemblies_Click;
            // 
            // btnString
            // 
            btnString.Location = new Point(551, 38);
            btnString.Name = "btnString";
            btnString.Size = new Size(140, 62);
            btnString.TabIndex = 3;
            btnString.Text = "String";
            btnString.UseVisualStyleBackColor = true;
            btnString.Click += btnString_Click;
            // 
            // btnArrayList
            // 
            btnArrayList.Location = new Point(12, 499);
            btnArrayList.Name = "btnArrayList";
            btnArrayList.Size = new Size(163, 95);
            btnArrayList.TabIndex = 4;
            btnArrayList.Text = "ArrayList Collection";
            btnArrayList.UseVisualStyleBackColor = true;
            btnArrayList.Click += btnArrayList_Click;
            // 
            // rtbTypes
            // 
            rtbTypes.Location = new Point(198, 136);
            rtbTypes.Name = "rtbTypes";
            rtbTypes.Size = new Size(662, 144);
            rtbTypes.TabIndex = 5;
            rtbTypes.Text = "";
            // 
            // rtbAssemblies
            // 
            rtbAssemblies.Location = new Point(198, 297);
            rtbAssemblies.Name = "rtbAssemblies";
            rtbAssemblies.Size = new Size(662, 144);
            rtbAssemblies.TabIndex = 6;
            rtbAssemblies.Text = "";
            // 
            // rtbArrayList
            // 
            rtbArrayList.Location = new Point(198, 476);
            rtbArrayList.Name = "rtbArrayList";
            rtbArrayList.Size = new Size(662, 144);
            rtbArrayList.TabIndex = 7;
            rtbArrayList.Text = "";
            // 
            // frmReflection
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 680);
            Controls.Add(rtbArrayList);
            Controls.Add(rtbAssemblies);
            Controls.Add(rtbTypes);
            Controls.Add(btnArrayList);
            Controls.Add(btnString);
            Controls.Add(btnAssemblies);
            Controls.Add(btnTypes);
            Controls.Add(btnDouble);
            Name = "frmReflection";
            Text = "Reflection App";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDouble;
        private Button btnTypes;
        private Button btnAssemblies;
        private Button btnString;
        private Button btnArrayList;
        private RichTextBox rtbTypes;
        private RichTextBox rtbAssemblies;
        private RichTextBox rtbArrayList;
    }
}
