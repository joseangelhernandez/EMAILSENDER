namespace EmailSender
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
            tbEmailReceptor = new TextBox();
            tbAsunto = new TextBox();
            tbCuerpoMsg = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnEnviar = new Button();
            btnCancelar = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // tbEmailReceptor
            // 
            tbEmailReceptor.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            tbEmailReceptor.Location = new Point(192, 85);
            tbEmailReceptor.Margin = new Padding(4);
            tbEmailReceptor.Name = "tbEmailReceptor";
            tbEmailReceptor.PlaceholderText = "Escribir Receptor";
            tbEmailReceptor.Size = new Size(664, 32);
            tbEmailReceptor.TabIndex = 0;
            // 
            // tbAsunto
            // 
            tbAsunto.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            tbAsunto.Location = new Point(192, 143);
            tbAsunto.Margin = new Padding(4);
            tbAsunto.Name = "tbAsunto";
            tbAsunto.PlaceholderText = "Escribir Asunto";
            tbAsunto.Size = new Size(664, 32);
            tbAsunto.TabIndex = 1;
            // 
            // tbCuerpoMsg
            // 
            tbCuerpoMsg.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            tbCuerpoMsg.Location = new Point(192, 203);
            tbCuerpoMsg.Margin = new Padding(4);
            tbCuerpoMsg.Multiline = true;
            tbCuerpoMsg.Name = "tbCuerpoMsg";
            tbCuerpoMsg.PlaceholderText = "Escribir Mensaje";
            tbCuerpoMsg.Size = new Size(664, 440);
            tbCuerpoMsg.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(94, 86);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(74, 29);
            label1.TabIndex = 3;
            label1.Text = "Para:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(69, 144);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(99, 29);
            label2.TabIndex = 4;
            label2.Text = "Asunto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(49, 203);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(119, 29);
            label3.TabIndex = 5;
            label3.Text = "Mensaje:";
            // 
            // btnEnviar
            // 
            btnEnviar.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnEnviar.Location = new Point(428, 652);
            btnEnviar.Margin = new Padding(4);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(428, 89);
            btnEnviar.TabIndex = 6;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Microsoft Sans Serif", 14.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(190, 652);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(230, 89);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(428, 22);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(97, 46);
            label4.TabIndex = 8;
            label4.Text = "Mail";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 793);
            Controls.Add(label4);
            Controls.Add(btnCancelar);
            Controls.Add(btnEnviar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbCuerpoMsg);
            Controls.Add(tbAsunto);
            Controls.Add(tbEmailReceptor);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "EMAIL SENDER - JJ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbEmailReceptor;
        private TextBox tbAsunto;
        private TextBox tbCuerpoMsg;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnEnviar;
        private Button btnCancelar;
        private Label label4;
    }
}