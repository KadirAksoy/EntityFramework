namespace EntityFrameWorkApplication
{
    partial class Form1
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
            this.list_student = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.upgrade = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.list_lesson = new System.Windows.Forms.Button();
            this.list_not = new System.Windows.Forms.Button();
            this.student = new System.Windows.Forms.GroupBox();
            this.imagetextbox = new System.Windows.Forms.TextBox();
            this.image = new System.Windows.Forms.Label();
            this.surnametextbox = new System.Windows.Forms.TextBox();
            this.surname = new System.Windows.Forms.Label();
            this.nametextbox = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.idtextbox = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            this.lesson = new System.Windows.Forms.GroupBox();
            this.lessonnametextbox = new System.Windows.Forms.TextBox();
            this.lesson_name = new System.Windows.Forms.Label();
            this.lessontextbox = new System.Windows.Forms.TextBox();
            this.lesson_id = new System.Windows.Forms.Label();
            this.notes = new System.Windows.Forms.GroupBox();
            this.calculate = new System.Windows.Forms.Button();
            this.updateexamnot = new System.Windows.Forms.Button();
            this.resultbox = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Label();
            this.averagebox = new System.Windows.Forms.TextBox();
            this.average = new System.Windows.Forms.Label();
            this.exam3box = new System.Windows.Forms.TextBox();
            this.exam3 = new System.Windows.Forms.Label();
            this.exam2box = new System.Windows.Forms.TextBox();
            this.exam2 = new System.Windows.Forms.Label();
            this.exam1box = new System.Windows.Forms.TextBox();
            this.exam1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.student.SuspendLayout();
            this.lesson.SuspendLayout();
            this.notes.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(695, 311);
            this.dataGridView1.TabIndex = 0;
            // 
            // list_student
            // 
            this.list_student.Location = new System.Drawing.Point(0, 317);
            this.list_student.Name = "list_student";
            this.list_student.Size = new System.Drawing.Size(191, 32);
            this.list_student.TabIndex = 1;
            this.list_student.Text = "List Student";
            this.list_student.UseVisualStyleBackColor = true;
            this.list_student.Click += new System.EventHandler(this.button1_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(0, 355);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(191, 32);
            this.save.TabIndex = 2;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(0, 393);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(191, 32);
            this.delete.TabIndex = 3;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.button3_Click);
            // 
            // upgrade
            // 
            this.upgrade.Location = new System.Drawing.Point(0, 431);
            this.upgrade.Name = "upgrade";
            this.upgrade.Size = new System.Drawing.Size(191, 32);
            this.upgrade.TabIndex = 4;
            this.upgrade.Text = "Update";
            this.upgrade.UseVisualStyleBackColor = true;
            this.upgrade.Click += new System.EventHandler(this.upgrade_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(0, 469);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(191, 32);
            this.search.TabIndex = 5;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // list_lesson
            // 
            this.list_lesson.Location = new System.Drawing.Point(0, 507);
            this.list_lesson.Name = "list_lesson";
            this.list_lesson.Size = new System.Drawing.Size(191, 32);
            this.list_lesson.TabIndex = 6;
            this.list_lesson.Text = "List Lesson";
            this.list_lesson.UseVisualStyleBackColor = true;
            this.list_lesson.Click += new System.EventHandler(this.button6_Click);
            // 
            // list_not
            // 
            this.list_not.Location = new System.Drawing.Point(0, 545);
            this.list_not.Name = "list_not";
            this.list_not.Size = new System.Drawing.Size(191, 32);
            this.list_not.TabIndex = 7;
            this.list_not.Text = "List Note";
            this.list_not.UseVisualStyleBackColor = true;
            this.list_not.Click += new System.EventHandler(this.list_not_Click);
            // 
            // student
            // 
            this.student.Controls.Add(this.imagetextbox);
            this.student.Controls.Add(this.image);
            this.student.Controls.Add(this.surnametextbox);
            this.student.Controls.Add(this.surname);
            this.student.Controls.Add(this.nametextbox);
            this.student.Controls.Add(this.name);
            this.student.Controls.Add(this.idtextbox);
            this.student.Controls.Add(this.id);
            this.student.Location = new System.Drawing.Point(197, 317);
            this.student.Name = "student";
            this.student.Size = new System.Drawing.Size(253, 161);
            this.student.TabIndex = 8;
            this.student.TabStop = false;
            this.student.Text = "Student";
            // 
            // imagetextbox
            // 
            this.imagetextbox.Location = new System.Drawing.Point(96, 114);
            this.imagetextbox.Name = "imagetextbox";
            this.imagetextbox.Size = new System.Drawing.Size(100, 22);
            this.imagetextbox.TabIndex = 14;
            this.imagetextbox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // image
            // 
            this.image.AutoSize = true;
            this.image.Location = new System.Drawing.Point(39, 117);
            this.image.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(49, 16);
            this.image.TabIndex = 15;
            this.image.Text = "IMAGE";
            // 
            // surnametextbox
            // 
            this.surnametextbox.Location = new System.Drawing.Point(96, 86);
            this.surnametextbox.Name = "surnametextbox";
            this.surnametextbox.Size = new System.Drawing.Size(100, 22);
            this.surnametextbox.TabIndex = 12;
            // 
            // surname
            // 
            this.surname.AutoSize = true;
            this.surname.Location = new System.Drawing.Point(13, 89);
            this.surname.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(75, 16);
            this.surname.TabIndex = 13;
            this.surname.Text = "SURNAME";
            // 
            // nametextbox
            // 
            this.nametextbox.Location = new System.Drawing.Point(96, 56);
            this.nametextbox.Name = "nametextbox";
            this.nametextbox.Size = new System.Drawing.Size(100, 22);
            this.nametextbox.TabIndex = 10;
            this.nametextbox.TextChanged += new System.EventHandler(this.nametextbox_TextChanged);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(42, 59);
            this.name.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(46, 16);
            this.name.TabIndex = 11;
            this.name.Text = "NAME";
            // 
            // idtextbox
            // 
            this.idtextbox.Location = new System.Drawing.Point(96, 28);
            this.idtextbox.Name = "idtextbox";
            this.idtextbox.Size = new System.Drawing.Size(100, 22);
            this.idtextbox.TabIndex = 9;
            this.idtextbox.TextChanged += new System.EventHandler(this.idtextbox_TextChanged);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(68, 31);
            this.id.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(20, 16);
            this.id.TabIndex = 9;
            this.id.Text = "ID";
            this.id.Click += new System.EventHandler(this.label1_Click);
            // 
            // lesson
            // 
            this.lesson.Controls.Add(this.lessonnametextbox);
            this.lesson.Controls.Add(this.lesson_name);
            this.lesson.Controls.Add(this.lessontextbox);
            this.lesson.Controls.Add(this.lesson_id);
            this.lesson.Location = new System.Drawing.Point(197, 488);
            this.lesson.Name = "lesson";
            this.lesson.Size = new System.Drawing.Size(253, 89);
            this.lesson.TabIndex = 9;
            this.lesson.TabStop = false;
            this.lesson.Text = "Lesson";
            // 
            // lessonnametextbox
            // 
            this.lessonnametextbox.Location = new System.Drawing.Point(96, 56);
            this.lessonnametextbox.Name = "lessonnametextbox";
            this.lessonnametextbox.Size = new System.Drawing.Size(100, 22);
            this.lessonnametextbox.TabIndex = 10;
            // 
            // lesson_name
            // 
            this.lesson_name.AutoSize = true;
            this.lesson_name.Location = new System.Drawing.Point(42, 59);
            this.lesson_name.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lesson_name.Name = "lesson_name";
            this.lesson_name.Size = new System.Drawing.Size(46, 16);
            this.lesson_name.TabIndex = 11;
            this.lesson_name.Text = "NAME";
            // 
            // lessontextbox
            // 
            this.lessontextbox.Location = new System.Drawing.Point(96, 28);
            this.lessontextbox.Name = "lessontextbox";
            this.lessontextbox.Size = new System.Drawing.Size(100, 22);
            this.lessontextbox.TabIndex = 9;
            // 
            // lesson_id
            // 
            this.lesson_id.AutoSize = true;
            this.lesson_id.Location = new System.Drawing.Point(68, 31);
            this.lesson_id.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lesson_id.Name = "lesson_id";
            this.lesson_id.Size = new System.Drawing.Size(20, 16);
            this.lesson_id.TabIndex = 9;
            this.lesson_id.Text = "ID";
            // 
            // notes
            // 
            this.notes.Controls.Add(this.calculate);
            this.notes.Controls.Add(this.updateexamnot);
            this.notes.Controls.Add(this.resultbox);
            this.notes.Controls.Add(this.result);
            this.notes.Controls.Add(this.averagebox);
            this.notes.Controls.Add(this.average);
            this.notes.Controls.Add(this.exam3box);
            this.notes.Controls.Add(this.exam3);
            this.notes.Controls.Add(this.exam2box);
            this.notes.Controls.Add(this.exam2);
            this.notes.Controls.Add(this.exam1box);
            this.notes.Controls.Add(this.exam1);
            this.notes.Location = new System.Drawing.Point(467, 317);
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(228, 260);
            this.notes.TabIndex = 10;
            this.notes.TabStop = false;
            this.notes.Text = "Notes";
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(6, 170);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(191, 32);
            this.calculate.TabIndex = 19;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            // 
            // updateexamnot
            // 
            this.updateexamnot.Location = new System.Drawing.Point(6, 214);
            this.updateexamnot.Name = "updateexamnot";
            this.updateexamnot.Size = new System.Drawing.Size(191, 32);
            this.updateexamnot.TabIndex = 18;
            this.updateexamnot.Text = "Update Exam Note";
            this.updateexamnot.UseVisualStyleBackColor = true;
            // 
            // resultbox
            // 
            this.resultbox.Location = new System.Drawing.Point(96, 142);
            this.resultbox.Name = "resultbox";
            this.resultbox.Size = new System.Drawing.Size(100, 22);
            this.resultbox.TabIndex = 16;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(32, 145);
            this.result.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(61, 16);
            this.result.TabIndex = 17;
            this.result.Text = "RESULT";
            // 
            // averagebox
            // 
            this.averagebox.Location = new System.Drawing.Point(96, 114);
            this.averagebox.Name = "averagebox";
            this.averagebox.Size = new System.Drawing.Size(100, 22);
            this.averagebox.TabIndex = 14;
            // 
            // average
            // 
            this.average.AutoSize = true;
            this.average.Location = new System.Drawing.Point(21, 117);
            this.average.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.average.Name = "average";
            this.average.Size = new System.Drawing.Size(72, 16);
            this.average.TabIndex = 15;
            this.average.Text = "AVERAGE";
            // 
            // exam3box
            // 
            this.exam3box.Location = new System.Drawing.Point(96, 86);
            this.exam3box.Name = "exam3box";
            this.exam3box.Size = new System.Drawing.Size(100, 22);
            this.exam3box.TabIndex = 12;
            // 
            // exam3
            // 
            this.exam3.AutoSize = true;
            this.exam3.Location = new System.Drawing.Point(42, 89);
            this.exam3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.exam3.Name = "exam3";
            this.exam3.Size = new System.Drawing.Size(51, 16);
            this.exam3.TabIndex = 13;
            this.exam3.Text = "EXAM3";
            this.exam3.Click += new System.EventHandler(this.label2_Click);
            // 
            // exam2box
            // 
            this.exam2box.Location = new System.Drawing.Point(96, 56);
            this.exam2box.Name = "exam2box";
            this.exam2box.Size = new System.Drawing.Size(100, 22);
            this.exam2box.TabIndex = 10;
            // 
            // exam2
            // 
            this.exam2.AutoSize = true;
            this.exam2.Location = new System.Drawing.Point(42, 59);
            this.exam2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.exam2.Name = "exam2";
            this.exam2.Size = new System.Drawing.Size(51, 16);
            this.exam2.TabIndex = 11;
            this.exam2.Text = "EXAM2";
            this.exam2.Click += new System.EventHandler(this.label3_Click);
            // 
            // exam1box
            // 
            this.exam1box.Location = new System.Drawing.Point(96, 28);
            this.exam1box.Name = "exam1box";
            this.exam1box.Size = new System.Drawing.Size(100, 22);
            this.exam1box.TabIndex = 9;
            // 
            // exam1
            // 
            this.exam1.AutoSize = true;
            this.exam1.Location = new System.Drawing.Point(42, 31);
            this.exam1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.exam1.Name = "exam1";
            this.exam1.Size = new System.Drawing.Size(51, 16);
            this.exam1.TabIndex = 9;
            this.exam1.Text = "EXAM1";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(701, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(164, 20);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "NAME ORDER BY A-Z";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(701, 531);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 32);
            this.button1.TabIndex = 20;
            this.button1.Text = "Linq Entity";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(701, 38);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(167, 20);
            this.radioButton2.TabIndex = 21;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "NAME ORDER BY Z-A ";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 679);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.notes);
            this.Controls.Add(this.lesson);
            this.Controls.Add(this.student);
            this.Controls.Add(this.list_not);
            this.Controls.Add(this.list_lesson);
            this.Controls.Add(this.search);
            this.Controls.Add(this.upgrade);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.save);
            this.Controls.Add(this.list_student);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.student.ResumeLayout(false);
            this.student.PerformLayout();
            this.lesson.ResumeLayout(false);
            this.lesson.PerformLayout();
            this.notes.ResumeLayout(false);
            this.notes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button list_student;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button upgrade;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button list_lesson;
        private System.Windows.Forms.Button list_not;
        private System.Windows.Forms.GroupBox student;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TextBox imagetextbox;
        private System.Windows.Forms.Label image;
        private System.Windows.Forms.TextBox surnametextbox;
        private System.Windows.Forms.Label surname;
        private System.Windows.Forms.TextBox nametextbox;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox idtextbox;
        private System.Windows.Forms.GroupBox lesson;
        private System.Windows.Forms.TextBox lessonnametextbox;
        private System.Windows.Forms.Label lesson_name;
        private System.Windows.Forms.TextBox lessontextbox;
        private System.Windows.Forms.Label lesson_id;
        private System.Windows.Forms.GroupBox notes;
        private System.Windows.Forms.TextBox resultbox;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.TextBox averagebox;
        private System.Windows.Forms.Label average;
        private System.Windows.Forms.TextBox exam3box;
        private System.Windows.Forms.Label exam3;
        private System.Windows.Forms.TextBox exam2box;
        private System.Windows.Forms.Label exam2;
        private System.Windows.Forms.TextBox exam1box;
        private System.Windows.Forms.Label exam1;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button updateexamnot;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}

