namespace Room_Creation
{
    partial class frmMain
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
            this.filedialog_profile = new System.Windows.Forms.OpenFileDialog();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_browse = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_room_number = new System.Windows.Forms.TextBox();
            this.lbl_room_number = new System.Windows.Forms.Label();
            this.txt_room_price = new System.Windows.Forms.TextBox();
            this.txt_room_type = new System.Windows.Forms.TextBox();
            this.lbl_room_price = new System.Windows.Forms.Label();
            this.lbl_room_type = new System.Windows.Forms.Label();
            this.picbox_room_picture = new System.Windows.Forms.PictureBox();
            this.lbl_photo = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_room_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Fira Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(480, 53);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(117, 36);
            this.btn_add.TabIndex = 96;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_browse
            // 
            this.btn_browse.Font = new System.Drawing.Font("Fira Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_browse.Location = new System.Drawing.Point(480, 247);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(117, 36);
            this.btn_browse.TabIndex = 87;
            this.btn_browse.Text = "BROWSE";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Fira Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(480, 110);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(117, 36);
            this.btn_search.TabIndex = 86;
            this.btn_search.Text = "SEARCH";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_room_number
            // 
            this.txt_room_number.Font = new System.Drawing.Font("Fira Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_room_number.Location = new System.Drawing.Point(228, 53);
            this.txt_room_number.Name = "txt_room_number";
            this.txt_room_number.Size = new System.Drawing.Size(226, 36);
            this.txt_room_number.TabIndex = 83;
            // 
            // lbl_room_number
            // 
            this.lbl_room_number.AutoSize = true;
            this.lbl_room_number.Font = new System.Drawing.Font("Fira Sans", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_room_number.Location = new System.Drawing.Point(83, 61);
            this.lbl_room_number.Name = "lbl_room_number";
            this.lbl_room_number.Size = new System.Drawing.Size(132, 23);
            this.lbl_room_number.TabIndex = 91;
            this.lbl_room_number.Text = "Room Number";
            this.lbl_room_number.Click += new System.EventHandler(this.lbl_student_id_Click);
            // 
            // txt_room_price
            // 
            this.txt_room_price.Font = new System.Drawing.Font("Fira Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_room_price.Location = new System.Drawing.Point(228, 165);
            this.txt_room_price.Name = "txt_room_price";
            this.txt_room_price.Size = new System.Drawing.Size(226, 36);
            this.txt_room_price.TabIndex = 85;
            // 
            // txt_room_type
            // 
            this.txt_room_type.Font = new System.Drawing.Font("Fira Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_room_type.Location = new System.Drawing.Point(228, 108);
            this.txt_room_type.Name = "txt_room_type";
            this.txt_room_type.Size = new System.Drawing.Size(226, 36);
            this.txt_room_type.TabIndex = 84;
            // 
            // lbl_room_price
            // 
            this.lbl_room_price.AutoSize = true;
            this.lbl_room_price.Font = new System.Drawing.Font("Fira Sans", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_room_price.Location = new System.Drawing.Point(109, 173);
            this.lbl_room_price.Name = "lbl_room_price";
            this.lbl_room_price.Size = new System.Drawing.Size(106, 23);
            this.lbl_room_price.TabIndex = 90;
            this.lbl_room_price.Text = "Room Price";
            this.lbl_room_price.Click += new System.EventHandler(this.lbl_address_Click);
            // 
            // lbl_room_type
            // 
            this.lbl_room_type.AutoSize = true;
            this.lbl_room_type.Font = new System.Drawing.Font("Fira Sans", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_room_type.Location = new System.Drawing.Point(112, 116);
            this.lbl_room_type.Name = "lbl_room_type";
            this.lbl_room_type.Size = new System.Drawing.Size(103, 23);
            this.lbl_room_type.TabIndex = 89;
            this.lbl_room_type.Text = "Room Type";
            this.lbl_room_type.Click += new System.EventHandler(this.lbl_student_name_Click);
            // 
            // picbox_room_picture
            // 
            this.picbox_room_picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbox_room_picture.Location = new System.Drawing.Point(228, 247);
            this.picbox_room_picture.Name = "picbox_room_picture";
            this.picbox_room_picture.Size = new System.Drawing.Size(225, 224);
            this.picbox_room_picture.TabIndex = 97;
            this.picbox_room_picture.TabStop = false;
            // 
            // lbl_photo
            // 
            this.lbl_photo.AutoSize = true;
            this.lbl_photo.Font = new System.Drawing.Font("Fira Sans", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_photo.Location = new System.Drawing.Point(154, 253);
            this.lbl_photo.Name = "lbl_photo";
            this.lbl_photo.Size = new System.Drawing.Size(61, 23);
            this.lbl_photo.TabIndex = 98;
            this.lbl_photo.Text = "Photo";
            this.lbl_photo.Click += new System.EventHandler(this.lbl_photo_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Fira Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(480, 165);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(117, 36);
            this.btn_delete.TabIndex = 99;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_show
            // 
            this.btn_show.Font = new System.Drawing.Font("Fira Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show.Location = new System.Drawing.Point(480, 435);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(117, 36);
            this.btn_show.TabIndex = 100;
            this.btn_show.Text = "SHOW";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 511);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.lbl_photo);
            this.Controls.Add(this.picbox_room_picture);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_room_number);
            this.Controls.Add(this.lbl_room_number);
            this.Controls.Add(this.txt_room_price);
            this.Controls.Add(this.txt_room_type);
            this.Controls.Add(this.lbl_room_price);
            this.Controls.Add(this.lbl_room_type);
            this.Name = "frmMain";
            this.Text = "frmMain";
            ((System.ComponentModel.ISupportInitialize)(this.picbox_room_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog filedialog_profile;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_room_number;
        private System.Windows.Forms.Label lbl_room_number;
        private System.Windows.Forms.TextBox txt_room_price;
        private System.Windows.Forms.TextBox txt_room_type;
        private System.Windows.Forms.Label lbl_room_price;
        private System.Windows.Forms.Label lbl_room_type;
        private System.Windows.Forms.PictureBox picbox_room_picture;
        private System.Windows.Forms.Label lbl_photo;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_show;
    }
}