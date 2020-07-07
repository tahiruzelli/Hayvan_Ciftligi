namespace proje_ödevim
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tavukcan = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btntavukyem = new System.Windows.Forms.Button();
            this.lbltavukcanlimi = new System.Windows.Forms.Label();
            this.btnordekyem = new System.Windows.Forms.Button();
            this.lblordekcanlimi = new System.Windows.Forms.Label();
            this.ordekcan = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblinekcanlimi = new System.Windows.Forms.Label();
            this.lblkecicanlimi = new System.Windows.Forms.Label();
            this.btninekyem = new System.Windows.Forms.Button();
            this.btnkeciyem = new System.Windows.Forms.Button();
            this.inekcan = new System.Windows.Forms.ProgressBar();
            this.kecican = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblkasa = new System.Windows.Forms.Label();
            this.lblsure = new System.Windows.Forms.Label();
            this.btntavuksat = new System.Windows.Forms.Button();
            this.btnordeksat = new System.Windows.Forms.Button();
            this.btnineksat = new System.Windows.Forms.Button();
            this.btnkecisat = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbltavukadet = new System.Windows.Forms.Label();
            this.lblinekadet = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblordekadet = new System.Windows.Forms.Label();
            this.lblkeciadet = new System.Windows.Forms.Label();
            this.tmrinekcan = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tavukyumurta = new System.Windows.Forms.Timer(this.components);
            this.ordekyumurta = new System.Windows.Forms.Timer(this.components);
            this.ineksut = new System.Windows.Forms.Timer(this.components);
            this.kecisut = new System.Windows.Forms.Timer(this.components);
            this.tmrkecican = new System.Windows.Forms.Timer(this.components);
            this.tmrordekcan = new System.Windows.Forms.Timer(this.components);
            this.tmrtavukcan = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // tavukcan
            // 
            this.tavukcan.Location = new System.Drawing.Point(217, 311);
            this.tavukcan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tavukcan.Name = "tavukcan";
            this.tavukcan.Size = new System.Drawing.Size(267, 25);
            this.tavukcan.TabIndex = 0;
            this.tavukcan.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(65, 225);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kümes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(65, 273);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(65, 393);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(152, 101);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // btntavukyem
            // 
            this.btntavukyem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntavukyem.ForeColor = System.Drawing.Color.Red;
            this.btntavukyem.Location = new System.Drawing.Point(217, 343);
            this.btntavukyem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btntavukyem.Name = "btntavukyem";
            this.btntavukyem.Size = new System.Drawing.Size(267, 31);
            this.btntavukyem.TabIndex = 5;
            this.btntavukyem.Text = "Yem Ver";
            this.btntavukyem.UseVisualStyleBackColor = true;
            this.btntavukyem.Click += new System.EventHandler(this.btntavukyem_Click);
            // 
            // lbltavukcanlimi
            // 
            this.lbltavukcanlimi.BackColor = System.Drawing.SystemColors.Control;
            this.lbltavukcanlimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltavukcanlimi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbltavukcanlimi.Location = new System.Drawing.Point(217, 273);
            this.lbltavukcanlimi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltavukcanlimi.Name = "lbltavukcanlimi";
            this.lbltavukcanlimi.Size = new System.Drawing.Size(267, 31);
            this.lbltavukcanlimi.TabIndex = 6;
            this.lbltavukcanlimi.Text = "Canlı";
            this.lbltavukcanlimi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnordekyem
            // 
            this.btnordekyem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnordekyem.ForeColor = System.Drawing.Color.Red;
            this.btnordekyem.Location = new System.Drawing.Point(217, 463);
            this.btnordekyem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnordekyem.Name = "btnordekyem";
            this.btnordekyem.Size = new System.Drawing.Size(267, 31);
            this.btnordekyem.TabIndex = 7;
            this.btnordekyem.Text = "Yem Ver";
            this.btnordekyem.UseVisualStyleBackColor = true;
            this.btnordekyem.Click += new System.EventHandler(this.btnordekyem_Click);
            // 
            // lblordekcanlimi
            // 
            this.lblordekcanlimi.BackColor = System.Drawing.SystemColors.Control;
            this.lblordekcanlimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblordekcanlimi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblordekcanlimi.Location = new System.Drawing.Point(217, 393);
            this.lblordekcanlimi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblordekcanlimi.Name = "lblordekcanlimi";
            this.lblordekcanlimi.Size = new System.Drawing.Size(267, 31);
            this.lblordekcanlimi.TabIndex = 8;
            this.lblordekcanlimi.Text = "Canlı";
            this.lblordekcanlimi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ordekcan
            // 
            this.ordekcan.Location = new System.Drawing.Point(217, 431);
            this.ordekcan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ordekcan.Name = "ordekcan";
            this.ordekcan.Size = new System.Drawing.Size(267, 25);
            this.ordekcan.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(545, 225);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(416, 33);
            this.label3.TabIndex = 10;
            this.label3.Text = "  Ahır";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(545, 273);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(152, 101);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(545, 393);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(152, 101);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // lblinekcanlimi
            // 
            this.lblinekcanlimi.BackColor = System.Drawing.SystemColors.Control;
            this.lblinekcanlimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblinekcanlimi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblinekcanlimi.Location = new System.Drawing.Point(700, 273);
            this.lblinekcanlimi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblinekcanlimi.Name = "lblinekcanlimi";
            this.lblinekcanlimi.Size = new System.Drawing.Size(267, 31);
            this.lblinekcanlimi.TabIndex = 13;
            this.lblinekcanlimi.Text = "Canlı";
            this.lblinekcanlimi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblinekcanlimi.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblkecicanlimi
            // 
            this.lblkecicanlimi.BackColor = System.Drawing.SystemColors.Control;
            this.lblkecicanlimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkecicanlimi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblkecicanlimi.Location = new System.Drawing.Point(700, 393);
            this.lblkecicanlimi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblkecicanlimi.Name = "lblkecicanlimi";
            this.lblkecicanlimi.Size = new System.Drawing.Size(267, 31);
            this.lblkecicanlimi.TabIndex = 14;
            this.lblkecicanlimi.Text = "Canlı";
            this.lblkecicanlimi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btninekyem
            // 
            this.btninekyem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btninekyem.ForeColor = System.Drawing.Color.Red;
            this.btninekyem.Location = new System.Drawing.Point(700, 343);
            this.btninekyem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btninekyem.Name = "btninekyem";
            this.btninekyem.Size = new System.Drawing.Size(267, 31);
            this.btninekyem.TabIndex = 15;
            this.btninekyem.Text = "Yem Ver";
            this.btninekyem.UseVisualStyleBackColor = true;
            this.btninekyem.Click += new System.EventHandler(this.btninekyem_Click);
            // 
            // btnkeciyem
            // 
            this.btnkeciyem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkeciyem.ForeColor = System.Drawing.Color.Red;
            this.btnkeciyem.Location = new System.Drawing.Point(700, 463);
            this.btnkeciyem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnkeciyem.Name = "btnkeciyem";
            this.btnkeciyem.Size = new System.Drawing.Size(267, 31);
            this.btnkeciyem.TabIndex = 16;
            this.btnkeciyem.Text = "Yem Ver";
            this.btnkeciyem.UseVisualStyleBackColor = true;
            this.btnkeciyem.Click += new System.EventHandler(this.btnkeciyem_Click);
            // 
            // inekcan
            // 
            this.inekcan.Location = new System.Drawing.Point(700, 311);
            this.inekcan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inekcan.Name = "inekcan";
            this.inekcan.Size = new System.Drawing.Size(267, 25);
            this.inekcan.TabIndex = 17;
            // 
            // kecican
            // 
            this.kecican.Location = new System.Drawing.Point(700, 431);
            this.kecican.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kecican.Name = "kecican";
            this.kecican.Size = new System.Drawing.Size(267, 25);
            this.kecican.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(65, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(419, 33);
            this.label2.TabIndex = 19;
            this.label2.Text = "            Ürün Deposu";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(545, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 33);
            this.label4.TabIndex = 20;
            this.label4.Text = "Gıda Fabrikası";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(820, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 33);
            this.label5.TabIndex = 21;
            this.label5.Text = "Geçen Süre";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(820, 121);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 33);
            this.label6.TabIndex = 22;
            this.label6.Text = "Kasa";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblkasa
            // 
            this.lblkasa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblkasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkasa.Location = new System.Drawing.Point(820, 165);
            this.lblkasa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblkasa.Name = "lblkasa";
            this.lblkasa.Size = new System.Drawing.Size(141, 49);
            this.lblkasa.TabIndex = 23;
            this.lblkasa.Text = "0";
            this.lblkasa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblsure
            // 
            this.lblsure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblsure.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsure.Location = new System.Drawing.Point(820, 57);
            this.lblsure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsure.Name = "lblsure";
            this.lblsure.Size = new System.Drawing.Size(141, 49);
            this.lblsure.TabIndex = 24;
            this.lblsure.Text = "0";
            this.lblsure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblsure.Click += new System.EventHandler(this.lblsure_Click);
            // 
            // btntavuksat
            // 
            this.btntavuksat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntavuksat.ForeColor = System.Drawing.Color.Red;
            this.btntavuksat.Location = new System.Drawing.Point(545, 55);
            this.btntavuksat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btntavuksat.Name = "btntavuksat";
            this.btntavuksat.Size = new System.Drawing.Size(253, 33);
            this.btntavuksat.TabIndex = 25;
            this.btntavuksat.Text = "Tavuk Yumurtası Sat";
            this.btntavuksat.UseVisualStyleBackColor = true;
            this.btntavuksat.Click += new System.EventHandler(this.btntavuksat_Click);
            // 
            // btnordeksat
            // 
            this.btnordeksat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnordeksat.ForeColor = System.Drawing.Color.Red;
            this.btnordeksat.Location = new System.Drawing.Point(545, 97);
            this.btnordeksat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnordeksat.Name = "btnordeksat";
            this.btnordeksat.Size = new System.Drawing.Size(253, 33);
            this.btnordeksat.TabIndex = 26;
            this.btnordeksat.Text = "Ördek Yumurtası Sat";
            this.btnordeksat.UseVisualStyleBackColor = true;
            this.btnordeksat.Click += new System.EventHandler(this.btnordeksat_Click);
            // 
            // btnineksat
            // 
            this.btnineksat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnineksat.ForeColor = System.Drawing.Color.Red;
            this.btnineksat.Location = new System.Drawing.Point(545, 139);
            this.btnineksat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnineksat.Name = "btnineksat";
            this.btnineksat.Size = new System.Drawing.Size(253, 33);
            this.btnineksat.TabIndex = 27;
            this.btnineksat.Text = "İnek Sütü Sat";
            this.btnineksat.UseVisualStyleBackColor = true;
            this.btnineksat.Click += new System.EventHandler(this.btnineksat_Click);
            // 
            // btnkecisat
            // 
            this.btnkecisat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkecisat.ForeColor = System.Drawing.Color.Red;
            this.btnkecisat.Location = new System.Drawing.Point(545, 181);
            this.btnkecisat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnkecisat.Name = "btnkecisat";
            this.btnkecisat.Size = new System.Drawing.Size(253, 33);
            this.btnkecisat.TabIndex = 28;
            this.btnkecisat.Text = "Keçi Sütü Sat";
            this.btnkecisat.UseVisualStyleBackColor = true;
            this.btnkecisat.Click += new System.EventHandler(this.btnkecisat_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(65, 57);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 28);
            this.label7.TabIndex = 29;
            this.label7.Text = "Tavuk Yumurtası";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(284, 57);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 28);
            this.label8.TabIndex = 30;
            this.label8.Text = "İnek Sütü";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbltavukadet
            // 
            this.lbltavukadet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbltavukadet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbltavukadet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltavukadet.Location = new System.Drawing.Point(65, 92);
            this.lbltavukadet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltavukadet.Name = "lbltavukadet";
            this.lbltavukadet.Size = new System.Drawing.Size(203, 37);
            this.lbltavukadet.TabIndex = 31;
            this.lbltavukadet.Text = "0";
            this.lbltavukadet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbltavukadet.Click += new System.EventHandler(this.lbltavukadet_Click);
            // 
            // lblinekadet
            // 
            this.lblinekadet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblinekadet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblinekadet.Location = new System.Drawing.Point(284, 92);
            this.lblinekadet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblinekadet.Name = "lblinekadet";
            this.lblinekadet.Size = new System.Drawing.Size(200, 37);
            this.lblinekadet.TabIndex = 32;
            this.lblinekadet.Text = "0";
            this.lblinekadet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(284, 134);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(200, 28);
            this.label11.TabIndex = 33;
            this.label11.Text = "Keçi Sütü";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(65, 134);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(203, 28);
            this.label12.TabIndex = 34;
            this.label12.Text = "Ördek Yumurtası";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // lblordekadet
            // 
            this.lblordekadet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblordekadet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblordekadet.Location = new System.Drawing.Point(65, 171);
            this.lblordekadet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblordekadet.Name = "lblordekadet";
            this.lblordekadet.Size = new System.Drawing.Size(203, 37);
            this.lblordekadet.TabIndex = 35;
            this.lblordekadet.Text = "0";
            this.lblordekadet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblkeciadet
            // 
            this.lblkeciadet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblkeciadet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkeciadet.Location = new System.Drawing.Point(284, 171);
            this.lblkeciadet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblkeciadet.Name = "lblkeciadet";
            this.lblkeciadet.Size = new System.Drawing.Size(200, 37);
            this.lblkeciadet.TabIndex = 36;
            this.lblkeciadet.Text = "0";
            this.lblkeciadet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblkeciadet.Click += new System.EventHandler(this.lblkeciadet_Click);
            // 
            // tmrinekcan
            // 
            this.tmrinekcan.Interval = 1000;
            this.tmrinekcan.Tick += new System.EventHandler(this.tmrinekcan_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // tavukyumurta
            // 
            this.tavukyumurta.Interval = 3000;
            this.tavukyumurta.Tick += new System.EventHandler(this.tavukyumurta_Tick);
            // 
            // ordekyumurta
            // 
            this.ordekyumurta.Interval = 5000;
            this.ordekyumurta.Tick += new System.EventHandler(this.ordekyumurta_Tick);
            // 
            // ineksut
            // 
            this.ineksut.Interval = 8000;
            this.ineksut.Tick += new System.EventHandler(this.ineksut_Tick);
            // 
            // kecisut
            // 
            this.kecisut.Interval = 7000;
            this.kecisut.Tick += new System.EventHandler(this.kecisut_Tick);
            // 
            // tmrkecican
            // 
            this.tmrkecican.Interval = 1000;
            this.tmrkecican.Tick += new System.EventHandler(this.tmrkecican_Tick);
            // 
            // tmrordekcan
            // 
            this.tmrordekcan.Interval = 1000;
            this.tmrordekcan.Tick += new System.EventHandler(this.tmrordekcan_Tick);
            // 
            // tmrtavukcan
            // 
            this.tmrtavukcan.Interval = 1000;
            this.tmrtavukcan.Tick += new System.EventHandler(this.tmrtavukcan_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1033, 524);
            this.Controls.Add(this.lblkeciadet);
            this.Controls.Add(this.lblordekadet);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblinekadet);
            this.Controls.Add(this.lbltavukadet);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnkecisat);
            this.Controls.Add(this.btnineksat);
            this.Controls.Add(this.btnordeksat);
            this.Controls.Add(this.btntavuksat);
            this.Controls.Add(this.lblsure);
            this.Controls.Add(this.lblkasa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kecican);
            this.Controls.Add(this.inekcan);
            this.Controls.Add(this.btnkeciyem);
            this.Controls.Add(this.btninekyem);
            this.Controls.Add(this.lblkecicanlimi);
            this.Controls.Add(this.lblinekcanlimi);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ordekcan);
            this.Controls.Add(this.lblordekcanlimi);
            this.Controls.Add(this.btnordekyem);
            this.Controls.Add(this.lbltavukcanlimi);
            this.Controls.Add(this.btntavukyem);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tavukcan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Hayvan Çiftliği";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar tavukcan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btntavukyem;
        private System.Windows.Forms.Label lbltavukcanlimi;
        private System.Windows.Forms.Button btnordekyem;
        private System.Windows.Forms.Label lblordekcanlimi;
        private System.Windows.Forms.ProgressBar ordekcan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblinekcanlimi;
        private System.Windows.Forms.Label lblkecicanlimi;
        private System.Windows.Forms.Button btninekyem;
        private System.Windows.Forms.Button btnkeciyem;
        private System.Windows.Forms.ProgressBar inekcan;
        private System.Windows.Forms.ProgressBar kecican;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblkasa;
        private System.Windows.Forms.Label lblsure;
        private System.Windows.Forms.Button btntavuksat;
        private System.Windows.Forms.Button btnordeksat;
        private System.Windows.Forms.Button btnineksat;
        private System.Windows.Forms.Button btnkecisat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbltavukadet;
        private System.Windows.Forms.Label lblinekadet;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblordekadet;
        private System.Windows.Forms.Label lblkeciadet;
        private System.Windows.Forms.Timer tmrinekcan;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer tavukyumurta;
        private System.Windows.Forms.Timer ordekyumurta;
        private System.Windows.Forms.Timer ineksut;
        private System.Windows.Forms.Timer kecisut;
        private System.Windows.Forms.Timer tmrkecican;
        private System.Windows.Forms.Timer tmrordekcan;
        private System.Windows.Forms.Timer tmrtavukcan;
    }
}

