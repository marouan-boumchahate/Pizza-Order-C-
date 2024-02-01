namespace PizzaOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.rdThik = new System.Windows.Forms.RadioButton();
            this.rdThin = new System.Windows.Forms.RadioButton();
            this.rdOutside = new System.Windows.Forms.RadioButton();
            this.rdHere = new System.Windows.Forms.RadioButton();
            this.vSize = new System.Windows.Forms.Label();
            this.vToppings = new System.Windows.Forms.Label();
            this.vCrust = new System.Windows.Forms.Label();
            this.vEatingPlace = new System.Windows.Forms.Label();
            this.sizeInfo = new System.Windows.Forms.Label();
            this.toppingsInfo = new System.Windows.Forms.Label();
            this.crustInfo = new System.Windows.Forms.Label();
            this.eatingInfo = new System.Windows.Forms.Label();
            this.grpSize = new System.Windows.Forms.GroupBox();
            this.rdLarge = new System.Windows.Forms.RadioButton();
            this.rdMedium = new System.Windows.Forms.RadioButton();
            this.rdSmall = new System.Windows.Forms.RadioButton();
            this.grpToppings = new System.Windows.Forms.GroupBox();
            this.chkTomatoe = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkMushroom = new System.Windows.Forms.CheckBox();
            this.chkCheese = new System.Windows.Forms.CheckBox();
            this.chkOlive = new System.Windows.Forms.CheckBox();
            this.chkGreenPepper = new System.Windows.Forms.CheckBox();
            this.grpCrust = new System.Windows.Forms.GroupBox();
            this.grpEatingPlace = new System.Windows.Forms.GroupBox();
            this.vPrice = new System.Windows.Forms.Label();
            this.priceInfo = new System.Windows.Forms.Label();
            this.btnTakeOrder = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpSize.SuspendLayout();
            this.grpToppings.SuspendLayout();
            this.grpCrust.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Permanent Marker", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(336, -8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(752, 103);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAKE YOUR PIZZA";
            // 
            // rdThik
            // 
            this.rdThik.AutoSize = true;
            this.rdThik.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdThik.Location = new System.Drawing.Point(42, 104);
            this.rdThik.Margin = new System.Windows.Forms.Padding(4);
            this.rdThik.Name = "rdThik";
            this.rdThik.Size = new System.Drawing.Size(83, 27);
            this.rdThik.TabIndex = 11;
            this.rdThik.TabStop = true;
            this.rdThik.Tag = "5";
            this.rdThik.Text = "Thick";
            this.rdThik.UseVisualStyleBackColor = true;
            this.rdThik.CheckedChanged += new System.EventHandler(this.rdThik_CheckedChanged);
            // 
            // rdThin
            // 
            this.rdThin.AutoSize = true;
            this.rdThin.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdThin.Location = new System.Drawing.Point(42, 45);
            this.rdThin.Margin = new System.Windows.Forms.Padding(4);
            this.rdThin.Name = "rdThin";
            this.rdThin.Size = new System.Drawing.Size(73, 27);
            this.rdThin.TabIndex = 10;
            this.rdThin.TabStop = true;
            this.rdThin.Tag = "5";
            this.rdThin.Text = "Thin";
            this.rdThin.UseVisualStyleBackColor = true;
            this.rdThin.CheckedChanged += new System.EventHandler(this.rdThin_CheckedChanged);
            // 
            // rdOutside
            // 
            this.rdOutside.AutoSize = true;
            this.rdOutside.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdOutside.Location = new System.Drawing.Point(464, 500);
            this.rdOutside.Margin = new System.Windows.Forms.Padding(4);
            this.rdOutside.Name = "rdOutside";
            this.rdOutside.Size = new System.Drawing.Size(101, 27);
            this.rdOutside.TabIndex = 13;
            this.rdOutside.TabStop = true;
            this.rdOutside.Text = "Outside";
            this.rdOutside.UseVisualStyleBackColor = true;
            this.rdOutside.CheckedChanged += new System.EventHandler(this.rdOutside_CheckedChanged);
            // 
            // rdHere
            // 
            this.rdHere.AutoSize = true;
            this.rdHere.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdHere.Location = new System.Drawing.Point(464, 441);
            this.rdHere.Margin = new System.Windows.Forms.Padding(4);
            this.rdHere.Name = "rdHere";
            this.rdHere.Size = new System.Drawing.Size(78, 27);
            this.rdHere.TabIndex = 12;
            this.rdHere.TabStop = true;
            this.rdHere.Text = "Here";
            this.rdHere.UseVisualStyleBackColor = true;
            this.rdHere.CheckedChanged += new System.EventHandler(this.rdHere_CheckedChanged);
            // 
            // vSize
            // 
            this.vSize.AutoSize = true;
            this.vSize.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vSize.ForeColor = System.Drawing.Color.Yellow;
            this.vSize.Location = new System.Drawing.Point(42, 55);
            this.vSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vSize.Name = "vSize";
            this.vSize.Size = new System.Drawing.Size(72, 26);
            this.vSize.TabIndex = 14;
            this.vSize.Text = "Size  :";
            // 
            // vToppings
            // 
            this.vToppings.AutoSize = true;
            this.vToppings.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vToppings.ForeColor = System.Drawing.Color.Yellow;
            this.vToppings.Location = new System.Drawing.Point(42, 125);
            this.vToppings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vToppings.Name = "vToppings";
            this.vToppings.Size = new System.Drawing.Size(124, 26);
            this.vToppings.TabIndex = 15;
            this.vToppings.Text = "Toppings  :";
            // 
            // vCrust
            // 
            this.vCrust.AutoSize = true;
            this.vCrust.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vCrust.ForeColor = System.Drawing.Color.Yellow;
            this.vCrust.Location = new System.Drawing.Point(42, 249);
            this.vCrust.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vCrust.Name = "vCrust";
            this.vCrust.Size = new System.Drawing.Size(145, 26);
            this.vCrust.TabIndex = 16;
            this.vCrust.Text = "Crust Type  :";
            // 
            // vEatingPlace
            // 
            this.vEatingPlace.AutoSize = true;
            this.vEatingPlace.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vEatingPlace.ForeColor = System.Drawing.Color.Yellow;
            this.vEatingPlace.Location = new System.Drawing.Point(42, 321);
            this.vEatingPlace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vEatingPlace.Name = "vEatingPlace";
            this.vEatingPlace.Size = new System.Drawing.Size(162, 26);
            this.vEatingPlace.TabIndex = 17;
            this.vEatingPlace.Text = "Eating Place  :";
            // 
            // sizeInfo
            // 
            this.sizeInfo.AutoSize = true;
            this.sizeInfo.Location = new System.Drawing.Point(1087, 153);
            this.sizeInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sizeInfo.Name = "sizeInfo";
            this.sizeInfo.Size = new System.Drawing.Size(0, 25);
            this.sizeInfo.TabIndex = 18;
            // 
            // toppingsInfo
            // 
            this.toppingsInfo.AutoSize = true;
            this.toppingsInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toppingsInfo.Location = new System.Drawing.Point(1147, 224);
            this.toppingsInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.toppingsInfo.Name = "toppingsInfo";
            this.toppingsInfo.Size = new System.Drawing.Size(0, 25);
            this.toppingsInfo.TabIndex = 19;
            // 
            // crustInfo
            // 
            this.crustInfo.AutoSize = true;
            this.crustInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crustInfo.Location = new System.Drawing.Point(1172, 348);
            this.crustInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.crustInfo.Name = "crustInfo";
            this.crustInfo.Size = new System.Drawing.Size(0, 25);
            this.crustInfo.TabIndex = 20;
            // 
            // eatingInfo
            // 
            this.eatingInfo.AutoSize = true;
            this.eatingInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eatingInfo.Location = new System.Drawing.Point(1172, 420);
            this.eatingInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.eatingInfo.Name = "eatingInfo";
            this.eatingInfo.Size = new System.Drawing.Size(0, 25);
            this.eatingInfo.TabIndex = 21;
            // 
            // grpSize
            // 
            this.grpSize.Controls.Add(this.rdLarge);
            this.grpSize.Controls.Add(this.rdMedium);
            this.grpSize.Controls.Add(this.rdSmall);
            this.grpSize.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSize.Location = new System.Drawing.Point(83, 98);
            this.grpSize.Name = "grpSize";
            this.grpSize.Size = new System.Drawing.Size(210, 260);
            this.grpSize.TabIndex = 22;
            this.grpSize.TabStop = false;
            this.grpSize.Text = "Size";
            // 
            // rdLarge
            // 
            this.rdLarge.AutoSize = true;
            this.rdLarge.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdLarge.Location = new System.Drawing.Point(49, 197);
            this.rdLarge.Margin = new System.Windows.Forms.Padding(4);
            this.rdLarge.Name = "rdLarge";
            this.rdLarge.Size = new System.Drawing.Size(86, 27);
            this.rdLarge.TabIndex = 31;
            this.rdLarge.TabStop = true;
            this.rdLarge.Tag = "50";
            this.rdLarge.Text = "Large";
            this.rdLarge.UseVisualStyleBackColor = true;
            this.rdLarge.CheckedChanged += new System.EventHandler(this.rdLarge_CheckedChanged);
            // 
            // rdMedium
            // 
            this.rdMedium.AutoSize = true;
            this.rdMedium.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMedium.Location = new System.Drawing.Point(49, 127);
            this.rdMedium.Margin = new System.Windows.Forms.Padding(4);
            this.rdMedium.Name = "rdMedium";
            this.rdMedium.Size = new System.Drawing.Size(103, 27);
            this.rdMedium.TabIndex = 30;
            this.rdMedium.TabStop = true;
            this.rdMedium.Tag = "40";
            this.rdMedium.Text = "Medium";
            this.rdMedium.UseVisualStyleBackColor = true;
            this.rdMedium.CheckedChanged += new System.EventHandler(this.rdMedium_CheckedChanged);
            // 
            // rdSmall
            // 
            this.rdSmall.AutoSize = true;
            this.rdSmall.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSmall.Location = new System.Drawing.Point(49, 57);
            this.rdSmall.Margin = new System.Windows.Forms.Padding(4);
            this.rdSmall.Name = "rdSmall";
            this.rdSmall.Size = new System.Drawing.Size(81, 27);
            this.rdSmall.TabIndex = 29;
            this.rdSmall.TabStop = true;
            this.rdSmall.Tag = "30";
            this.rdSmall.Text = "Small";
            this.rdSmall.UseVisualStyleBackColor = true;
            this.rdSmall.CheckedChanged += new System.EventHandler(this.rdSmall_CheckedChanged);
            // 
            // grpToppings
            // 
            this.grpToppings.Controls.Add(this.chkTomatoe);
            this.grpToppings.Controls.Add(this.chkOnion);
            this.grpToppings.Controls.Add(this.chkMushroom);
            this.grpToppings.Controls.Add(this.chkCheese);
            this.grpToppings.Controls.Add(this.chkOlive);
            this.grpToppings.Controls.Add(this.chkGreenPepper);
            this.grpToppings.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpToppings.Location = new System.Drawing.Point(434, 98);
            this.grpToppings.Name = "grpToppings";
            this.grpToppings.Size = new System.Drawing.Size(455, 260);
            this.grpToppings.TabIndex = 23;
            this.grpToppings.TabStop = false;
            this.grpToppings.Text = "Toppings";
            // 
            // chkTomatoe
            // 
            this.chkTomatoe.AutoSize = true;
            this.chkTomatoe.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTomatoe.Location = new System.Drawing.Point(30, 197);
            this.chkTomatoe.Margin = new System.Windows.Forms.Padding(4);
            this.chkTomatoe.Name = "chkTomatoe";
            this.chkTomatoe.Size = new System.Drawing.Size(117, 27);
            this.chkTomatoe.TabIndex = 28;
            this.chkTomatoe.Tag = "5";
            this.chkTomatoe.Text = "Tomatoes";
            this.chkTomatoe.UseVisualStyleBackColor = true;
            this.chkTomatoe.CheckedChanged += new System.EventHandler(this.chkTomatoe_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOnion.Location = new System.Drawing.Point(269, 57);
            this.chkOnion.Margin = new System.Windows.Forms.Padding(4);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(87, 27);
            this.chkOnion.TabIndex = 29;
            this.chkOnion.Tag = "5";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkMushroom
            // 
            this.chkMushroom.AutoSize = true;
            this.chkMushroom.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMushroom.Location = new System.Drawing.Point(30, 128);
            this.chkMushroom.Margin = new System.Windows.Forms.Padding(4);
            this.chkMushroom.Name = "chkMushroom";
            this.chkMushroom.Size = new System.Drawing.Size(133, 27);
            this.chkMushroom.TabIndex = 27;
            this.chkMushroom.Tag = "5";
            this.chkMushroom.Text = "Mushrooms";
            this.chkMushroom.UseVisualStyleBackColor = true;
            this.chkMushroom.CheckedChanged += new System.EventHandler(this.chkMushroom_CheckedChanged);
            // 
            // chkCheese
            // 
            this.chkCheese.AutoSize = true;
            this.chkCheese.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCheese.Location = new System.Drawing.Point(30, 58);
            this.chkCheese.Margin = new System.Windows.Forms.Padding(4);
            this.chkCheese.Name = "chkCheese";
            this.chkCheese.Size = new System.Drawing.Size(151, 27);
            this.chkCheese.TabIndex = 26;
            this.chkCheese.Tag = "5";
            this.chkCheese.Text = "Extra Cheese";
            this.chkCheese.UseVisualStyleBackColor = true;
            this.chkCheese.CheckedChanged += new System.EventHandler(this.chkCheese_CheckedChanged);
            // 
            // chkOlive
            // 
            this.chkOlive.AutoSize = true;
            this.chkOlive.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOlive.Location = new System.Drawing.Point(269, 127);
            this.chkOlive.Margin = new System.Windows.Forms.Padding(4);
            this.chkOlive.Name = "chkOlive";
            this.chkOlive.Size = new System.Drawing.Size(90, 27);
            this.chkOlive.TabIndex = 30;
            this.chkOlive.Tag = "5";
            this.chkOlive.Text = "Olives";
            this.chkOlive.UseVisualStyleBackColor = true;
            this.chkOlive.CheckedChanged += new System.EventHandler(this.chkOlive_CheckedChanged);
            // 
            // chkGreenPepper
            // 
            this.chkGreenPepper.AutoSize = true;
            this.chkGreenPepper.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGreenPepper.Location = new System.Drawing.Point(269, 198);
            this.chkGreenPepper.Margin = new System.Windows.Forms.Padding(4);
            this.chkGreenPepper.Name = "chkGreenPepper";
            this.chkGreenPepper.Size = new System.Drawing.Size(155, 27);
            this.chkGreenPepper.TabIndex = 31;
            this.chkGreenPepper.Tag = "5";
            this.chkGreenPepper.Text = "Green Pepper";
            this.chkGreenPepper.UseVisualStyleBackColor = true;
            this.chkGreenPepper.CheckedChanged += new System.EventHandler(this.chkGreenPepper_CheckedChanged);
            // 
            // grpCrust
            // 
            this.grpCrust.Controls.Add(this.rdThik);
            this.grpCrust.Controls.Add(this.rdThin);
            this.grpCrust.Font = new System.Drawing.Font("Ravie", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCrust.Location = new System.Drawing.Point(91, 396);
            this.grpCrust.Name = "grpCrust";
            this.grpCrust.Size = new System.Drawing.Size(202, 150);
            this.grpCrust.TabIndex = 24;
            this.grpCrust.TabStop = false;
            this.grpCrust.Text = "Crust";
            // 
            // grpEatingPlace
            // 
            this.grpEatingPlace.Font = new System.Drawing.Font("Ravie", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEatingPlace.Location = new System.Drawing.Point(434, 396);
            this.grpEatingPlace.Name = "grpEatingPlace";
            this.grpEatingPlace.Size = new System.Drawing.Size(232, 150);
            this.grpEatingPlace.TabIndex = 25;
            this.grpEatingPlace.TabStop = false;
            this.grpEatingPlace.Text = "Eating Place";
            // 
            // vPrice
            // 
            this.vPrice.AutoSize = true;
            this.vPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vPrice.ForeColor = System.Drawing.Color.Yellow;
            this.vPrice.Location = new System.Drawing.Point(42, 401);
            this.vPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vPrice.Name = "vPrice";
            this.vPrice.Size = new System.Drawing.Size(87, 26);
            this.vPrice.TabIndex = 26;
            this.vPrice.Text = "Price  :";
            // 
            // priceInfo
            // 
            this.priceInfo.AutoSize = true;
            this.priceInfo.Font = new System.Drawing.Font("Russo One", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceInfo.ForeColor = System.Drawing.Color.Lime;
            this.priceInfo.Location = new System.Drawing.Point(120, 427);
            this.priceInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceInfo.Name = "priceInfo";
            this.priceInfo.Size = new System.Drawing.Size(104, 68);
            this.priceInfo.TabIndex = 27;
            this.priceInfo.Tag = "0";
            this.priceInfo.Text = "$0";
            // 
            // btnTakeOrder
            // 
            this.btnTakeOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTakeOrder.Location = new System.Drawing.Point(434, 588);
            this.btnTakeOrder.Name = "btnTakeOrder";
            this.btnTakeOrder.Size = new System.Drawing.Size(132, 41);
            this.btnTakeOrder.TabIndex = 28;
            this.btnTakeOrder.Text = "Order";
            this.btnTakeOrder.UseVisualStyleBackColor = false;
            this.btnTakeOrder.Click += new System.EventHandler(this.btnTakeOrder_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReset.Location = new System.Drawing.Point(658, 588);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(132, 41);
            this.btnReset.TabIndex = 29;
            this.btnReset.Text = "Reset Form";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.vCrust);
            this.groupBox5.Controls.Add(this.vSize);
            this.groupBox5.Controls.Add(this.priceInfo);
            this.groupBox5.Controls.Add(this.vToppings);
            this.groupBox5.Controls.Add(this.vPrice);
            this.groupBox5.Controls.Add(this.vEatingPlace);
            this.groupBox5.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(921, 98);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(310, 500);
            this.groupBox5.TabIndex = 32;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Order Summary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(167, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 22);
            this.label3.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(201, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 22);
            this.label5.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(183, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 22);
            this.label4.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 22);
            this.label2.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1237, 690);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnTakeOrder);
            this.Controls.Add(this.grpCrust);
            this.Controls.Add(this.grpSize);
            this.Controls.Add(this.eatingInfo);
            this.Controls.Add(this.crustInfo);
            this.Controls.Add(this.toppingsInfo);
            this.Controls.Add(this.sizeInfo);
            this.Controls.Add(this.rdOutside);
            this.Controls.Add(this.rdHere);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpToppings);
            this.Controls.Add(this.grpEatingPlace);
            this.Controls.Add(this.groupBox5);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Order HAMI\'s Pizza";
            this.grpSize.ResumeLayout(false);
            this.grpSize.PerformLayout();
            this.grpToppings.ResumeLayout(false);
            this.grpToppings.PerformLayout();
            this.grpCrust.ResumeLayout(false);
            this.grpCrust.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdThik;
        private System.Windows.Forms.RadioButton rdThin;
        private System.Windows.Forms.RadioButton rdOutside;
        private System.Windows.Forms.RadioButton rdHere;
        private System.Windows.Forms.Label vSize;
        private System.Windows.Forms.Label vToppings;
        private System.Windows.Forms.Label vCrust;
        private System.Windows.Forms.Label vEatingPlace;
        private System.Windows.Forms.Label sizeInfo;
        private System.Windows.Forms.Label toppingsInfo;
        private System.Windows.Forms.Label crustInfo;
        private System.Windows.Forms.Label eatingInfo;
        private System.Windows.Forms.GroupBox grpSize;
        private System.Windows.Forms.RadioButton rdLarge;
        private System.Windows.Forms.RadioButton rdMedium;
        private System.Windows.Forms.RadioButton rdSmall;
        private System.Windows.Forms.GroupBox grpToppings;
        private System.Windows.Forms.CheckBox chkTomatoe;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkMushroom;
        private System.Windows.Forms.CheckBox chkCheese;
        private System.Windows.Forms.CheckBox chkOlive;
        private System.Windows.Forms.CheckBox chkGreenPepper;
        private System.Windows.Forms.GroupBox grpCrust;
        private System.Windows.Forms.GroupBox grpEatingPlace;
        private System.Windows.Forms.Label vPrice;
        private System.Windows.Forms.Label priceInfo;
        private System.Windows.Forms.Button btnTakeOrder;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

