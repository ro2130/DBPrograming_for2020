namespace BasicFileIO
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonBinaryWriter = new System.Windows.Forms.Button();
            this.buttonBinaryReader = new System.Windows.Forms.Button();
            this.buttonStreamWriter = new System.Windows.Forms.Button();
            this.ButtonStreamReader = new System.Windows.Forms.Button();
            this.textBoxDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonBinaryWriter
            // 
            this.buttonBinaryWriter.Location = new System.Drawing.Point(90, 23);
            this.buttonBinaryWriter.Name = "buttonBinaryWriter";
            this.buttonBinaryWriter.Size = new System.Drawing.Size(253, 72);
            this.buttonBinaryWriter.TabIndex = 0;
            this.buttonBinaryWriter.Text = "BinaryWriter";
            this.buttonBinaryWriter.UseVisualStyleBackColor = true;
            this.buttonBinaryWriter.Click += new System.EventHandler(this.buttonBinaryWriter_Click);
            // 
            // buttonBinaryReader
            // 
            this.buttonBinaryReader.Location = new System.Drawing.Point(442, 23);
            this.buttonBinaryReader.Name = "buttonBinaryReader";
            this.buttonBinaryReader.Size = new System.Drawing.Size(253, 72);
            this.buttonBinaryReader.TabIndex = 1;
            this.buttonBinaryReader.Text = "BinaryReader";
            this.buttonBinaryReader.UseVisualStyleBackColor = true;
            this.buttonBinaryReader.Click += new System.EventHandler(this.buttonBinaryReader_Click);
            // 
            // buttonStreamWriter
            // 
            this.buttonStreamWriter.Location = new System.Drawing.Point(90, 128);
            this.buttonStreamWriter.Name = "buttonStreamWriter";
            this.buttonStreamWriter.Size = new System.Drawing.Size(253, 72);
            this.buttonStreamWriter.TabIndex = 2;
            this.buttonStreamWriter.Text = "StreamWriter";
            this.buttonStreamWriter.UseVisualStyleBackColor = true;
            this.buttonStreamWriter.Click += new System.EventHandler(this.buttonStreamWriter_Click);
            // 
            // ButtonStreamReader
            // 
            this.ButtonStreamReader.Location = new System.Drawing.Point(442, 128);
            this.ButtonStreamReader.Name = "ButtonStreamReader";
            this.ButtonStreamReader.Size = new System.Drawing.Size(253, 72);
            this.ButtonStreamReader.TabIndex = 3;
            this.ButtonStreamReader.Text = "StreamReader";
            this.ButtonStreamReader.UseVisualStyleBackColor = true;
            this.ButtonStreamReader.Click += new System.EventHandler(this.ButtonStreamReader_Click);
            // 
            // textBoxDisplay
            // 
            this.textBoxDisplay.Location = new System.Drawing.Point(90, 238);
            this.textBoxDisplay.Multiline = true;
            this.textBoxDisplay.Name = "textBoxDisplay";
            this.textBoxDisplay.Size = new System.Drawing.Size(605, 273);
            this.textBoxDisplay.TabIndex = 4;
            this.textBoxDisplay.Text = "Hello";
            this.textBoxDisplay.TextChanged += new System.EventHandler(this.textBoxDisplay_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 551);
            this.Controls.Add(this.textBoxDisplay);
            this.Controls.Add(this.ButtonStreamReader);
            this.Controls.Add(this.buttonStreamWriter);
            this.Controls.Add(this.buttonBinaryReader);
            this.Controls.Add(this.buttonBinaryWriter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBinaryWriter;
        private System.Windows.Forms.Button buttonBinaryReader;
        private System.Windows.Forms.Button buttonStreamWriter;
        private System.Windows.Forms.Button ButtonStreamReader;
        private System.Windows.Forms.TextBox textBoxDisplay;
    }
}

