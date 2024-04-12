namespace picturebox
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxMostrar = new System.Windows.Forms.PictureBox();
            this.buttonMostrar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.pictureboxMostrar2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxMostrar2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMostrar
            // 
            this.pictureBoxMostrar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMostrar.Image")));
            this.pictureBoxMostrar.Location = new System.Drawing.Point(24, 21);
            this.pictureBoxMostrar.Name = "pictureBoxMostrar";
            this.pictureBoxMostrar.Size = new System.Drawing.Size(520, 308);
            this.pictureBoxMostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMostrar.TabIndex = 0;
            this.pictureBoxMostrar.TabStop = false;
            this.pictureBoxMostrar.Visible = false;
            // 
            // buttonMostrar
            // 
            this.buttonMostrar.Location = new System.Drawing.Point(24, 371);
            this.buttonMostrar.Name = "buttonMostrar";
            this.buttonMostrar.Size = new System.Drawing.Size(520, 41);
            this.buttonMostrar.TabIndex = 1;
            this.buttonMostrar.Text = "Clique Para MOSTRAR a imagem!";
            this.buttonMostrar.UseVisualStyleBackColor = true;
            this.buttonMostrar.Click += new System.EventHandler(this.buttonMostrar_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(24, 451);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(520, 41);
            this.buttonApagar.TabIndex = 2;
            this.buttonApagar.Text = "Clique Para APAGAR a imagem!";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // pictureboxMostrar2
            // 
            this.pictureboxMostrar2.Image = ((System.Drawing.Image)(resources.GetObject("pictureboxMostrar2.Image")));
            this.pictureboxMostrar2.Location = new System.Drawing.Point(599, 21);
            this.pictureboxMostrar2.Name = "pictureboxMostrar2";
            this.pictureboxMostrar2.Size = new System.Drawing.Size(347, 308);
            this.pictureboxMostrar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureboxMostrar2.TabIndex = 3;
            this.pictureboxMostrar2.TabStop = false;
            this.pictureboxMostrar2.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(599, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(347, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Clique Para MOSTRAR imagem 2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(599, 451);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(347, 41);
            this.button2.TabIndex = 5;
            this.button2.Text = "Clique Para APAGAR imagem 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(244, 547);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(456, 47);
            this.button3.TabIndex = 6;
            this.button3.Text = "Fechar Todos !";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 625);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureboxMostrar2);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonMostrar);
            this.Controls.Add(this.pictureBoxMostrar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxMostrar2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMostrar;
        private System.Windows.Forms.Button buttonMostrar;
        private System.Windows.Forms.Button buttonApagar;
        private System.Windows.Forms.PictureBox pictureboxMostrar2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

