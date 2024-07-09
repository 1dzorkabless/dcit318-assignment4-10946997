namespace MyCanvas
{
    partial class Form1
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
            Board_PB = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Board_PB).BeginInit();
            SuspendLayout();
            // 
            // Board_PB
            // 
            Board_PB.Dock = DockStyle.Bottom;
            Board_PB.Location = new Point(0, 5);
            Board_PB.Name = "Board_PB";
            Board_PB.Size = new Size(800, 445);
            Board_PB.TabIndex = 0;
            Board_PB.TabStop = false;
            Board_PB.Click += pictureBox1_Click;
            Board_PB.MouseDown += Board_PB_MouseDown;
            Board_PB.MouseMove += Board_PB_MouseMove;
            Board_PB.MouseUp += Board_PB_MouseDown;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Board_PB);
            Name = "Form1";
            Text = "MyCanvas";
            ((System.ComponentModel.ISupportInitialize)Board_PB).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Board_PB;
    }
}
