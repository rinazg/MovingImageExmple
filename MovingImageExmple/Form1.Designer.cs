
namespace MovingImageExmple
{
    partial class frmMoveImage
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
            this.components = new System.ComponentModel.Container();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.btnMove = new System.Windows.Forms.Button();
            this.timerImageMove = new System.Windows.Forms.Timer(this.components);
            this.btnStop = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            this.SuspendLayout();
            // 
            // pb1
            // 
            this.pb1.Image = global::MovingImageExmple.Properties.Resources.zebra;
            this.pb1.Location = new System.Drawing.Point(12, 68);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(180, 214);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.Image = global::MovingImageExmple.Properties.Resources.lion;
            this.pb2.Location = new System.Drawing.Point(391, 68);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(173, 214);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb2.TabIndex = 1;
            this.pb2.TabStop = false;
            // 
            // btnMove
            // 
            this.btnMove.BackColor = System.Drawing.Color.Lime;
            this.btnMove.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMove.Location = new System.Drawing.Point(12, 336);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(272, 56);
            this.btnMove.TabIndex = 2;
            this.btnMove.Text = "Click to move image";
            this.btnMove.UseVisualStyleBackColor = false;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // timerImageMove
            // 
            this.timerImageMove.Tick += new System.EventHandler(this.timerImageMove_Tick);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Red;
            this.btnStop.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStop.Location = new System.Drawing.Point(331, 336);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(223, 56);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "stop moving";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Yellow;
            this.btnRestart.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRestart.Location = new System.Drawing.Point(615, 336);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(168, 55);
            this.btnRestart.TabIndex = 4;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // frmMoveImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Name = "frmMoveImage";
            this.Text = "Moving Image Example";
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Timer timerImageMove;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnRestart;
    }
}

