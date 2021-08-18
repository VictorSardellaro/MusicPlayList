
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
            this.btn_Add = new System.Windows.Forms.Button();
            this.lv_Mlist = new System.Windows.Forms.ListView();
            this.cl_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_PTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Singer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_MGenre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_NSong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mtb_DSong = new System.Windows.Forms.MaskedTextBox();
            this.btn_Updt = new System.Windows.Forms.Button();
            this.tb_PlaylistId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 20F);
            this.label1.Location = new System.Drawing.Point(293, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Music Playlist";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 20F);
            this.label2.Location = new System.Drawing.Point(97, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Register your playlist:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.label3.Location = new System.Drawing.Point(102, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Playlist Title:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.label4.Location = new System.Drawing.Point(102, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Singer:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.label5.Location = new System.Drawing.Point(102, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Musical Genre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.label6.Location = new System.Drawing.Point(102, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Name of the song:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.label7.Location = new System.Drawing.Point(102, 255);
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
            this.tb_NSong.Location = new System.Drawing.Point(291, 228);
            this.tb_NSong.Name = "tb_NSong";
            this.tb_NSong.Size = new System.Drawing.Size(100, 25);
            this.tb_NSong.TabIndex = 4;
            // 
            // tb_Genre
            // 
            this.tb_Genre.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tb_Genre.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.tb_Genre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_Genre.Location = new System.Drawing.Point(291, 200);
            this.tb_Genre.Name = "tb_Genre";
            this.tb_Genre.Size = new System.Drawing.Size(100, 25);
            this.tb_Genre.TabIndex = 3;
            // 
            // tb_Singer
            // 
            this.tb_Singer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tb_Singer.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.tb_Singer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_Singer.Location = new System.Drawing.Point(291, 174);
            this.tb_Singer.Name = "tb_Singer";
            this.tb_Singer.Size = new System.Drawing.Size(100, 25);
            this.tb_Singer.TabIndex = 2;
            // 
            // tb_PlaylistTitle
            // 
            this.tb_PlaylistTitle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tb_PlaylistTitle.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.tb_PlaylistTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_PlaylistTitle.Location = new System.Drawing.Point(291, 146);
            this.tb_PlaylistTitle.Name = "tb_PlaylistTitle";
            this.tb_PlaylistTitle.Size = new System.Drawing.Size(100, 25);
            this.tb_PlaylistTitle.TabIndex = 1;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Add.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.btn_Add.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Add.Location = new System.Drawing.Point(477, 132);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(126, 39);
            this.btn_Add.TabIndex = 6;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lv_Mlist
            // 
            this.lv_Mlist.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lv_Mlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cl_ID,
            this.cl_PTitle,
            this.cl_Singer,
            this.cl_MGenre,
            this.cl_NSong});
            this.lv_Mlist.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lv_Mlist.GridLines = true;
            this.lv_Mlist.HideSelection = false;
            this.lv_Mlist.Location = new System.Drawing.Point(12, 306);
            this.lv_Mlist.Name = "lv_Mlist";
            this.lv_Mlist.Size = new System.Drawing.Size(731, 284);
            this.lv_Mlist.TabIndex = 14;
            this.lv_Mlist.UseCompatibleStateImageBehavior = false;
            this.lv_Mlist.View = System.Windows.Forms.View.Details;
            // 
            // cl_ID
            // 
            this.cl_ID.Text = "ID";
            // 
            // cl_PTitle
            // 
            this.cl_PTitle.Text = "Title";
            this.cl_PTitle.Width = 143;
            // 
            // cl_Singer
            // 
            this.cl_Singer.Text = "Singer";
            this.cl_Singer.Width = 175;
            // 
            // cl_MGenre
            // 
            this.cl_MGenre.Text = "Genre";
            this.cl_MGenre.Width = 160;
            // 
            // cl_NSong
            // 
            this.cl_NSong.Text = "Song";
            this.cl_NSong.Width = 189;
            // 
            // mtb_DSong
            // 
            this.mtb_DSong.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mtb_DSong.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.mtb_DSong.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mtb_DSong.Location = new System.Drawing.Point(291, 256);
            this.mtb_DSong.Mask = "00:00:00";
            this.mtb_DSong.Name = "mtb_DSong";
            this.mtb_DSong.Size = new System.Drawing.Size(100, 25);
            this.mtb_DSong.TabIndex = 5;
            // 
            // btn_Updt
            // 
            this.btn_Updt.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Updt.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.btn_Updt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Updt.Location = new System.Drawing.Point(477, 200);
            this.btn_Updt.Name = "btn_Updt";
            this.btn_Updt.Size = new System.Drawing.Size(126, 39);
            this.btn_Updt.TabIndex = 15;
            this.btn_Updt.Text = "Update";
            this.btn_Updt.UseVisualStyleBackColor = false;
            this.btn_Updt.Click += new System.EventHandler(this.btn_Updt_Click);
            // 
            // tb_PlaylistId
            // 
            this.tb_PlaylistId.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tb_PlaylistId.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.tb_PlaylistId.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_PlaylistId.Location = new System.Drawing.Point(291, 114);
            this.tb_PlaylistId.Name = "tb_PlaylistId";
            this.tb_PlaylistId.Size = new System.Drawing.Size(100, 25);
            this.tb_PlaylistId.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.label8.Location = new System.Drawing.Point(102, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 23);
            this.label8.TabIndex = 18;
            this.label8.Text = "Playlist ID:";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(754, 602);
            this.Controls.Add(this.tb_PlaylistId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_Updt);
            this.Controls.Add(this.mtb_DSong);
            this.Controls.Add(this.lv_Mlist);
            this.Controls.Add(this.btn_Add);
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
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ListView lv_Mlist;
        private System.Windows.Forms.ColumnHeader cl_ID;
        private System.Windows.Forms.ColumnHeader cl_PTitle;
        private System.Windows.Forms.ColumnHeader cl_Singer;
        private System.Windows.Forms.ColumnHeader cl_MGenre;
        private System.Windows.Forms.ColumnHeader cl_NSong;
        private System.Windows.Forms.MaskedTextBox mtb_DSong;
        private System.Windows.Forms.Button btn_Updt;
        private System.Windows.Forms.TextBox tb_PlaylistId;
        private System.Windows.Forms.Label label8;
    }
}

