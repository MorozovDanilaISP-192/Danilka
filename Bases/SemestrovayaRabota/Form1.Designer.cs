namespace DataBase
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.INPUT = new System.Windows.Forms.TabControl();
            this.Автомобили = new System.Windows.Forms.TabPage();
            this.btn_del_t1 = new System.Windows.Forms.Button();
            this.btn_upp_t1 = new System.Windows.Forms.Button();
            this.btn_input_t1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.Клиенты = new System.Windows.Forms.TabPage();
            this.btn_del_t2 = new System.Windows.Forms.Button();
            this.btn_upp_t2 = new System.Windows.Forms.Button();
            this.btn_inp_t2 = new System.Windows.Forms.Button();
            this.btn_sel_t2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Продажи = new System.Windows.Forms.TabPage();
            this.btn_del_t3 = new System.Windows.Forms.Button();
            this.btn_upp_t3 = new System.Windows.Forms.Button();
            this.btn__inp_t3 = new System.Windows.Forms.Button();
            this.btn_sel_t3 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.График = new System.Windows.Forms.TabPage();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.cartesianChart1 = new LiveCharts.Wpf.CartesianChart();
            this.button1 = new System.Windows.Forms.Button();
            this.INPUT.SuspendLayout();
            this.Автомобили.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.Клиенты.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Продажи.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.График.SuspendLayout();
            this.SuspendLayout();
            // 
            // INPUT
            // 
            this.INPUT.Controls.Add(this.Автомобили);
            this.INPUT.Controls.Add(this.Клиенты);
            this.INPUT.Controls.Add(this.Продажи);
            this.INPUT.Controls.Add(this.График);
            this.INPUT.Location = new System.Drawing.Point(12, 12);
            this.INPUT.Name = "INPUT";
            this.INPUT.SelectedIndex = 0;
            this.INPUT.Size = new System.Drawing.Size(776, 426);
            this.INPUT.TabIndex = 0;
            // 
            // Автомобили
            // 
            this.Автомобили.Controls.Add(this.btn_del_t1);
            this.Автомобили.Controls.Add(this.btn_upp_t1);
            this.Автомобили.Controls.Add(this.btn_input_t1);
            this.Автомобили.Controls.Add(this.dataGridView2);
            this.Автомобили.Controls.Add(this.button2);
            this.Автомобили.Location = new System.Drawing.Point(4, 22);
            this.Автомобили.Name = "Автомобили";
            this.Автомобили.Padding = new System.Windows.Forms.Padding(3);
            this.Автомобили.Size = new System.Drawing.Size(768, 400);
            this.Автомобили.TabIndex = 0;
            this.Автомобили.Text = "Автомобили";
            this.Автомобили.UseVisualStyleBackColor = true;
            // 
            // btn_del_t1
            // 
            this.btn_del_t1.Location = new System.Drawing.Point(575, 329);
            this.btn_del_t1.Name = "btn_del_t1";
            this.btn_del_t1.Size = new System.Drawing.Size(185, 65);
            this.btn_del_t1.TabIndex = 7;
            this.btn_del_t1.Text = "DELETE";
            this.btn_del_t1.UseVisualStyleBackColor = true;
            this.btn_del_t1.Click += new System.EventHandler(this.btn_del_t1_Click);
            // 
            // btn_upp_t1
            // 
            this.btn_upp_t1.Location = new System.Drawing.Point(384, 329);
            this.btn_upp_t1.Name = "btn_upp_t1";
            this.btn_upp_t1.Size = new System.Drawing.Size(185, 65);
            this.btn_upp_t1.TabIndex = 6;
            this.btn_upp_t1.Text = "UPDATE";
            this.btn_upp_t1.UseVisualStyleBackColor = true;
            this.btn_upp_t1.Click += new System.EventHandler(this.btn_upp_t1_Click);
            // 
            // btn_input_t1
            // 
            this.btn_input_t1.Location = new System.Drawing.Point(194, 329);
            this.btn_input_t1.Name = "btn_input_t1";
            this.btn_input_t1.Size = new System.Drawing.Size(185, 65);
            this.btn_input_t1.TabIndex = 5;
            this.btn_input_t1.Text = "INPUT";
            this.btn_input_t1.UseVisualStyleBackColor = true;
            this.btn_input_t1.Click += new System.EventHandler(this.btn_input_t1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(7, 7);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(755, 315);
            this.dataGridView2.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.AccessibleName = "";
            this.button2.Location = new System.Drawing.Point(3, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 65);
            this.button2.TabIndex = 3;
            this.button2.Text = "SELECT ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // Клиенты
            // 
            this.Клиенты.Controls.Add(this.btn_del_t2);
            this.Клиенты.Controls.Add(this.btn_upp_t2);
            this.Клиенты.Controls.Add(this.btn_inp_t2);
            this.Клиенты.Controls.Add(this.btn_sel_t2);
            this.Клиенты.Controls.Add(this.dataGridView1);
            this.Клиенты.Location = new System.Drawing.Point(4, 22);
            this.Клиенты.Name = "Клиенты";
            this.Клиенты.Padding = new System.Windows.Forms.Padding(3);
            this.Клиенты.Size = new System.Drawing.Size(768, 400);
            this.Клиенты.TabIndex = 1;
            this.Клиенты.Text = "Клиенты";
            this.Клиенты.UseVisualStyleBackColor = true;
            // 
            // btn_del_t2
            // 
            this.btn_del_t2.Location = new System.Drawing.Point(579, 330);
            this.btn_del_t2.Name = "btn_del_t2";
            this.btn_del_t2.Size = new System.Drawing.Size(185, 65);
            this.btn_del_t2.TabIndex = 11;
            this.btn_del_t2.Text = "DELETE";
            this.btn_del_t2.UseVisualStyleBackColor = true;
            this.btn_del_t2.Click += new System.EventHandler(this.btn_del_t2_Click);
            // 
            // btn_upp_t2
            // 
            this.btn_upp_t2.Location = new System.Drawing.Point(388, 330);
            this.btn_upp_t2.Name = "btn_upp_t2";
            this.btn_upp_t2.Size = new System.Drawing.Size(185, 65);
            this.btn_upp_t2.TabIndex = 10;
            this.btn_upp_t2.Text = "UPDATE";
            this.btn_upp_t2.UseVisualStyleBackColor = true;
            this.btn_upp_t2.Click += new System.EventHandler(this.btn_upp_t2_Click);
            // 
            // btn_inp_t2
            // 
            this.btn_inp_t2.Location = new System.Drawing.Point(198, 330);
            this.btn_inp_t2.Name = "btn_inp_t2";
            this.btn_inp_t2.Size = new System.Drawing.Size(185, 65);
            this.btn_inp_t2.TabIndex = 9;
            this.btn_inp_t2.Text = "INPUT";
            this.btn_inp_t2.UseVisualStyleBackColor = true;
            this.btn_inp_t2.Click += new System.EventHandler(this.btn_inp_t2_Click);
            // 
            // btn_sel_t2
            // 
            this.btn_sel_t2.AccessibleName = "";
            this.btn_sel_t2.Location = new System.Drawing.Point(7, 329);
            this.btn_sel_t2.Name = "btn_sel_t2";
            this.btn_sel_t2.Size = new System.Drawing.Size(185, 65);
            this.btn_sel_t2.TabIndex = 8;
            this.btn_sel_t2.Text = "SELECT ";
            this.btn_sel_t2.UseVisualStyleBackColor = true;
            this.btn_sel_t2.Click += new System.EventHandler(this.btn_sel_t2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(755, 315);
            this.dataGridView1.TabIndex = 0;
            // 
            // Продажи
            // 
            this.Продажи.Controls.Add(this.btn_del_t3);
            this.Продажи.Controls.Add(this.btn_upp_t3);
            this.Продажи.Controls.Add(this.btn__inp_t3);
            this.Продажи.Controls.Add(this.btn_sel_t3);
            this.Продажи.Controls.Add(this.dataGridView3);
            this.Продажи.Location = new System.Drawing.Point(4, 22);
            this.Продажи.Name = "Продажи";
            this.Продажи.Padding = new System.Windows.Forms.Padding(3);
            this.Продажи.Size = new System.Drawing.Size(768, 400);
            this.Продажи.TabIndex = 2;
            this.Продажи.Text = "Продажи";
            this.Продажи.UseVisualStyleBackColor = true;
            // 
            // btn_del_t3
            // 
            this.btn_del_t3.Location = new System.Drawing.Point(578, 329);
            this.btn_del_t3.Name = "btn_del_t3";
            this.btn_del_t3.Size = new System.Drawing.Size(185, 65);
            this.btn_del_t3.TabIndex = 11;
            this.btn_del_t3.Text = "DELETE";
            this.btn_del_t3.UseVisualStyleBackColor = true;
            this.btn_del_t3.Click += new System.EventHandler(this.btn_del_t3_Click);
            // 
            // btn_upp_t3
            // 
            this.btn_upp_t3.Location = new System.Drawing.Point(387, 329);
            this.btn_upp_t3.Name = "btn_upp_t3";
            this.btn_upp_t3.Size = new System.Drawing.Size(185, 65);
            this.btn_upp_t3.TabIndex = 10;
            this.btn_upp_t3.Text = "UPDATE";
            this.btn_upp_t3.UseVisualStyleBackColor = true;
            this.btn_upp_t3.Click += new System.EventHandler(this.btn_upp_t3_Click);
            // 
            // btn__inp_t3
            // 
            this.btn__inp_t3.Location = new System.Drawing.Point(197, 329);
            this.btn__inp_t3.Name = "btn__inp_t3";
            this.btn__inp_t3.Size = new System.Drawing.Size(185, 65);
            this.btn__inp_t3.TabIndex = 9;
            this.btn__inp_t3.Text = "INPUT";
            this.btn__inp_t3.UseVisualStyleBackColor = true;
            this.btn__inp_t3.Click += new System.EventHandler(this.btn__inp_t3_Click);
            // 
            // btn_sel_t3
            // 
            this.btn_sel_t3.AccessibleName = "";
            this.btn_sel_t3.Location = new System.Drawing.Point(6, 328);
            this.btn_sel_t3.Name = "btn_sel_t3";
            this.btn_sel_t3.Size = new System.Drawing.Size(185, 65);
            this.btn_sel_t3.TabIndex = 8;
            this.btn_sel_t3.Text = "SELECT ";
            this.btn_sel_t3.UseVisualStyleBackColor = true;
            this.btn_sel_t3.Click += new System.EventHandler(this.btn_sel_t3_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(7, 7);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(755, 315);
            this.dataGridView3.TabIndex = 0;
            // 
            // График
            // 
            this.График.Controls.Add(this.button1);
            this.График.Controls.Add(this.elementHost1);
            this.График.Location = new System.Drawing.Point(4, 22);
            this.График.Name = "График";
            this.График.Size = new System.Drawing.Size(768, 400);
            this.График.TabIndex = 3;
            this.График.Text = "График";
            this.График.UseVisualStyleBackColor = true;
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(4, 21);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(760, 289);
            this.elementHost1.TabIndex = 0;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.cartesianChart1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(760, 79);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 450);
            this.Controls.Add(this.INPUT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.INPUT.ResumeLayout(false);
            this.Автомобили.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.Клиенты.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Продажи.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.График.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl INPUT;
        private System.Windows.Forms.TabPage Автомобили;
        private System.Windows.Forms.TabPage Клиенты;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage Продажи;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_del_t1;
        private System.Windows.Forms.Button btn_upp_t1;
        private System.Windows.Forms.Button btn_input_t1;
        private System.Windows.Forms.Button btn_del_t2;
        private System.Windows.Forms.Button btn_upp_t2;
        private System.Windows.Forms.Button btn_inp_t2;
        private System.Windows.Forms.Button btn_sel_t2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_del_t3;
        private System.Windows.Forms.Button btn_upp_t3;
        private System.Windows.Forms.Button btn__inp_t3;
        private System.Windows.Forms.Button btn_sel_t3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TabPage График;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private LiveCharts.Wpf.CartesianChart cartesianChart1;
    }
}

