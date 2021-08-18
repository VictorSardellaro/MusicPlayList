
namespace MusicPlayList
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_NSong = new System.Windows.Forms.TextBox();
            this.tb_Genre = new System.Windows.Forms.TextBox();
            this.tb_Singer = new System.Windows.Forms.TextBox();
            this.tb_PlaylistTitle = new System.Windows.Forms.TextBox();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.lv_Mlist = new System.Windows.Forms.ListView();
            this.cl_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_PTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_MGenre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_NSong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mtb_DSong = new System.Windows.Forms.MaskedTextBox();
            this.tb_PlaylistId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rb_Add = new System.Windows.Forms.RadioButton();
            this.rb_Update = new System.Windows.Forms.RadioButton();
            this.gb_Action = new System.Windows.Forms.GroupBox();
            this.cl_MDuration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gb_Action.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 20F);
            this.label1.Location = new System.Drawing.Point(349, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Music Playlist";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 20F);
            this.label2.Location = new System.Drawing.Point(175, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Register your playlist:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.label3.Location = new System.Drawing.Point(180, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Playlist Title:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.label4.Location = new System.Drawing.Point(180, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Author:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.label5.Location = new System.Drawing.Point(180, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Musical Genre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.label6.Location = new System.Drawing.Point(180, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Name of the song:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.label7.Location = new System.Drawing.Point(180, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Duration of the song:";
            // 
            // tb_NSong
            // 
            this.tb_NSong.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tb_NSong.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.tb_NSong.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_NSong.Location = new System.Drawing.Point(369, 228);
            this.tb_NSong.Name = "tb_NSong";
            this.tb_NSong.Size = new System.Drawing.Size(164, 25);
            this.tb_NSong.TabIndex = 4;
            // 
            // tb_Genre
            // 
            this.tb_Genre.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tb_Genre.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.tb_Genre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_Genre.Location = new System.Drawing.Point(369, 200);
            this.tb_Genre.Name = "tb_Genre";
            this.tb_Genre.Size = new System.Drawing.Size(164, 25);
            this.tb_Genre.TabIndex = 3;
            // 
            // tb_Singer
            // 
            this.tb_Singer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tb_Singer.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.tb_Singer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_Singer.Location = new System.Drawing.Point(369, 174);
            this.tb_Singer.Name = "tb_Singer";
            this.tb_Singer.Size = new System.Drawing.Size(164, 25);
            this.tb_Singer.TabIndex = 2;
            // 
            // tb_PlaylistTitle
            // 
            this.tb_PlaylistTitle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tb_PlaylistTitle.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.tb_PlaylistTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_PlaylistTitle.Location = new System.Drawing.Point(369, 146);
            this.tb_PlaylistTitle.Name = "tb_PlaylistTitle";
            this.tb_PlaylistTitle.Size = new System.Drawing.Size(164, 25);
            this.tb_PlaylistTitle.TabIndex = 1;
            // 
            // btn_Ok
            // 
            this.btn_Ok.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Ok.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.btn_Ok.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Ok.Location = new System.Drawing.Point(632, 233);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(126, 39);
            this.btn_Ok.TabIndex = 6;
            this.btn_Ok.Text = "Ok";
            this.btn_Ok.UseVisualStyleBackColor = false;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // lv_Mlist
            // 
            this.lv_Mlist.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lv_Mlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cl_ID,
            this.cl_PTitle,
            this.cl_Author,
            this.cl_MGenre,
            this.cl_NSong,
            this.cl_MDuration});
            this.lv_Mlist.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lv_Mlist.GridLines = true;
            this.lv_Mlist.HideSelection = false;
            this.lv_Mlist.Location = new System.Drawing.Point(12, 306);
            this.lv_Mlist.Name = "lv_Mlist";
            this.lv_Mlist.Size = new System.Drawing.Size(824, 284);
            this.lv_Mlist.TabIndex = 14;
            this.lv_Mlist.UseCompatibleStateImageBehavior = false;
            this.lv_Mlist.View = System.Windows.Forms.View.Details;
            // 
            // cl_ID
            // 
            this.cl_ID.Text = "ID";
            this.cl_ID.Width = 42;
            // 
            // cl_PTitle
            // 
            this.cl_PTitle.Text = "Playlist Title";
            this.cl_PTitle.Width = 218;
            // 
            // cl_Author
            // 
            this.cl_Author.Text = "Author";
            this.cl_Author.Width = 87;
            // 
            // cl_MGenre
            // 
            this.cl_MGenre.Text = "Genre";
            this.cl_MGenre.Width = 80;
            // 
            // cl_NSong
            // 
            this.cl_NSong.Text = "Song";
            this.cl_NSong.Width = 300;
            // 
            // mtb_DSong
            // 
            this.mtb_DSong.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mtb_DSong.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.mtb_DSong.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mtb_DSong.Location = new System.Drawing.Point(369, 256);
            this.mtb_DSong.Mask = "00:00:00";
            this.mtb_DSong.Name = "mtb_DSong";
            this.mtb_DSong.Size = new System.Drawing.Size(60, 25);
            this.mtb_DSong.TabIndex = 5;
            // 
            // tb_PlaylistId
            // 
            this.tb_PlaylistId.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tb_PlaylistId.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.tb_PlaylistId.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_PlaylistId.Location = new System.Drawing.Point(369, 114);
            this.tb_PlaylistId.Name = "tb_PlaylistId";
            this.tb_PlaylistId.Size = new System.Drawing.Size(164, 25);
            this.tb_PlaylistId.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.label8.Location = new System.Drawing.Point(180, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 23);
            this.label8.TabIndex = 18;
            this.label8.Text = "Playlist ID:";
            // 
            // rb_Add
            // 
            this.rb_Add.AutoSize = true;
            this.rb_Add.Location = new System.Drawing.Point(6, 13);
            this.rb_Add.Name = "rb_Add";
            this.rb_Add.Size = new System.Drawing.Size(48, 19);
            this.rb_Add.TabIndex = 19;
            this.rb_Add.TabStop = true;
            this.rb_Add.Text = "Add";
            this.rb_Add.UseVisualStyleBackColor = true;
            // 
            // rb_Update
            // 
            this.rb_Update.AutoSize = true;
            this.rb_Update.Location = new System.Drawing.Point(56, 13);
            this.rb_Update.Name = "rb_Update";
            this.rb_Update.Size = new System.Drawing.Size(64, 19);
            this.rb_Update.TabIndex = 20;
            this.rb_Update.TabStop = true;
            this.rb_Update.Text = "Update";
            this.rb_Update.UseVisualStyleBackColor = true;
            // 
            // gb_Action
            // 
            this.gb_Action.Controls.Add(this.rb_Update);
            this.gb_Action.Controls.Add(this.rb_Add);
            this.gb_Action.Location = new System.Drawing.Point(632, 182);
            this.gb_Action.Name = "gb_Action";
            this.gb_Action.Size = new System.Drawing.Size(126, 43);
            this.gb_Action.TabIndex = 21;
            this.gb_Action.TabStop = false;
            // 
            // cl_MDuration
            // 
            this.cl_MDuration.Text = "Music Duration";
            this.cl_MDuration.Width = 93;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(843, 602);
            this.Controls.Add(this.gb_Action);
            this.Controls.Add(this.tb_PlaylistId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mtb_DSong);
            this.Controls.Add(this.lv_Mlist);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.tb_PlaylistTitle);
            this.Controls.Add(this.tb_Singer);
            this.Controls.Add(this.tb_Genre);
            this.Controls.Add(this.tb_NSong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainScreen";
            this.Text = "Music Playlist";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.gb_Action.ResumeLayout(false);
            this.gb_Action.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_NSong;
        private System.Windows.Forms.TextBox tb_Genre;
        private System.Windows.Forms.TextBox tb_Singer;
        private System.Windows.Forms.TextBox tb_PlaylistTitle;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.ListView lv_Mlist;
        private System.Windows.Forms.ColumnHeader cl_ID;
        private System.Windows.Forms.ColumnHeader cl_PTitle;
        private System.Windows.Forms.ColumnHeader cl_Author;
        private System.Windows.Forms.ColumnHeader cl_MGenre;
        private System.Windows.Forms.ColumnHeader cl_NSong;
        private System.Windows.Forms.MaskedTextBox mtb_DSong;
        private System.Windows.Forms.TextBox tb_PlaylistId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rb_Add;
        private System.Windows.Forms.RadioButton rb_Update;
        private System.Windows.Forms.GroupBox gb_Action;
        private System.Windows.Forms.ColumnHeader cl_MDuration;
    }
}

