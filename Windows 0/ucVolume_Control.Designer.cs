namespace Windows_0
{
    partial class ucVolume_Control
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ucVolume_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ucVolume_Control";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ucVolume_Control_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ucVolume_Control_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ucVolume_Control_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ucVolume_Control_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
