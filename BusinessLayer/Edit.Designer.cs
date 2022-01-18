
namespace WindowsFormsApp1
{
    partial class Edit
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nazevText = new System.Windows.Forms.TextBox();
            this.rokText = new System.Windows.Forms.TextBox();
            this.zanrText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nazev = new System.Windows.Forms.Label();
            this.rok = new System.Windows.Forms.Label();
            this.zanr = new System.Windows.Forms.Label();
            this.herciText = new System.Windows.Forms.TextBox();
            this.reziserText = new System.Windows.Forms.TextBox();
            this.zamekCheck = new System.Windows.Forms.CheckBox();
            this.popisText = new System.Windows.Forms.RichTextBox();
            this.herci = new System.Windows.Forms.Label();
            this.reziser = new System.Windows.Forms.Label();
            this.ucinkujciView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucinkujciView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(359, 393);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // nazevText
            // 
            this.nazevText.Location = new System.Drawing.Point(503, 58);
            this.nazevText.Name = "nazevText";
            this.nazevText.Size = new System.Drawing.Size(100, 23);
            this.nazevText.TabIndex = 1;
            this.nazevText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rokText
            // 
            this.rokText.Location = new System.Drawing.Point(503, 87);
            this.rokText.Name = "rokText";
            this.rokText.Size = new System.Drawing.Size(100, 23);
            this.rokText.TabIndex = 2;
            // 
            // zanrText
            // 
            this.zanrText.Location = new System.Drawing.Point(503, 116);
            this.zanrText.Name = "zanrText";
            this.zanrText.Size = new System.Drawing.Size(100, 23);
            this.zanrText.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(666, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Potvrdit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seznam filmů v databázi";
            // 
            // nazev
            // 
            this.nazev.AutoSize = true;
            this.nazev.Location = new System.Drawing.Point(459, 58);
            this.nazev.Name = "nazev";
            this.nazev.Size = new System.Drawing.Size(39, 15);
            this.nazev.TabIndex = 6;
            this.nazev.Text = "Název";
            // 
            // rok
            // 
            this.rok.AutoSize = true;
            this.rok.Location = new System.Drawing.Point(459, 87);
            this.rok.Name = "rok";
            this.rok.Size = new System.Drawing.Size(27, 15);
            this.rok.TabIndex = 7;
            this.rok.Text = "Rok";
            // 
            // zanr
            // 
            this.zanr.AutoSize = true;
            this.zanr.Location = new System.Drawing.Point(459, 116);
            this.zanr.Name = "zanr";
            this.zanr.Size = new System.Drawing.Size(31, 15);
            this.zanr.TabIndex = 8;
            this.zanr.Text = "Žánr";
            // 
            // herciText
            // 
            this.herciText.Location = new System.Drawing.Point(503, 145);
            this.herciText.Name = "herciText";
            this.herciText.Size = new System.Drawing.Size(100, 23);
            this.herciText.TabIndex = 9;
            // 
            // reziserText
            // 
            this.reziserText.Location = new System.Drawing.Point(503, 174);
            this.reziserText.Name = "reziserText";
            this.reziserText.Size = new System.Drawing.Size(100, 23);
            this.reziserText.TabIndex = 10;
            // 
            // zamekCheck
            // 
            this.zamekCheck.AutoSize = true;
            this.zamekCheck.Location = new System.Drawing.Point(503, 305);
            this.zamekCheck.Name = "zamekCheck";
            this.zamekCheck.Size = new System.Drawing.Size(123, 19);
            this.zamekCheck.TabIndex = 11;
            this.zamekCheck.Text = "Rodičovský zámek";
            this.zamekCheck.UseVisualStyleBackColor = true;
            // 
            // popisText
            // 
            this.popisText.Location = new System.Drawing.Point(503, 203);
            this.popisText.Name = "popisText";
            this.popisText.Size = new System.Drawing.Size(100, 96);
            this.popisText.TabIndex = 12;
            this.popisText.Text = "";
            // 
            // herci
            // 
            this.herci.AutoSize = true;
            this.herci.Location = new System.Drawing.Point(426, 148);
            this.herci.Name = "herci";
            this.herci.Size = new System.Drawing.Size(72, 15);
            this.herci.TabIndex = 13;
            this.herci.Text = "Přidat Herce";
            // 
            // reziser
            // 
            this.reziser.AutoSize = true;
            this.reziser.Location = new System.Drawing.Point(414, 177);
            this.reziser.Name = "reziser";
            this.reziser.Size = new System.Drawing.Size(83, 15);
            this.reziser.TabIndex = 14;
            this.reziser.Text = "Přidat Režiséra";
            // 
            // ucinkujciView
            // 
            this.ucinkujciView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ucinkujciView.Location = new System.Drawing.Point(395, 341);
            this.ucinkujciView.Name = "ucinkujciView";
            this.ucinkujciView.RowTemplate.Height = 25;
            this.ucinkujciView.Size = new System.Drawing.Size(188, 97);
            this.ucinkujciView.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(623, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 454);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ucinkujciView);
            this.Controls.Add(this.reziser);
            this.Controls.Add(this.herci);
            this.Controls.Add(this.popisText);
            this.Controls.Add(this.zamekCheck);
            this.Controls.Add(this.reziserText);
            this.Controls.Add(this.herciText);
            this.Controls.Add(this.zanr);
            this.Controls.Add(this.rok);
            this.Controls.Add(this.nazev);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.zanrText);
            this.Controls.Add(this.rokText);
            this.Controls.Add(this.nazevText);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Edit";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucinkujciView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox nazevText;
        private System.Windows.Forms.TextBox rokText;
        private System.Windows.Forms.TextBox zanrText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nazev;
        private System.Windows.Forms.Label rok;
        private System.Windows.Forms.Label zanr;
        private System.Windows.Forms.TextBox herciText;
        private System.Windows.Forms.TextBox reziserText;
        private System.Windows.Forms.CheckBox zamekCheck;
        private System.Windows.Forms.RichTextBox popisText;
        private System.Windows.Forms.Label herci;
        private System.Windows.Forms.Label reziser;
        private System.Windows.Forms.DataGridView ucinkujciView;
        private System.Windows.Forms.Label label2;
    }
}