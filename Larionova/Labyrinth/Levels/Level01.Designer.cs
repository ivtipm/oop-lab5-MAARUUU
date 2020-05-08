namespace Labyrinth.Levels
{
    partial class Level01
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level01));
            this.start1 = new Labyrinth.Start();
            this.finish1 = new Labyrinth.Finish();
            this.wall2 = new Labyrinth.Wall();
            this.wall8 = new Labyrinth.Wall();
            this.wall7 = new Labyrinth.Wall();
            this.wall6 = new Labyrinth.Wall();
            this.wall5 = new Labyrinth.Wall();
            this.wall4 = new Labyrinth.Wall();
            this.wall3 = new Labyrinth.Wall();
            this.wall1 = new Labyrinth.Wall();
            this.SuspendLayout();
            // 
            // start1
            // 
            this.start1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("start1.BackgroundImage")));
            this.start1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.start1.Location = new System.Drawing.Point(31, 26);
            this.start1.Margin = new System.Windows.Forms.Padding(5);
            this.start1.Name = "start1";
            this.start1.Size = new System.Drawing.Size(95, 36);
            this.start1.TabIndex = 3;
            // 
            // finish1
            // 
            this.finish1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.finish1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("finish1.BackgroundImage")));
            this.finish1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.finish1.Location = new System.Drawing.Point(715, 567);
            this.finish1.Margin = new System.Windows.Forms.Padding(5);
            this.finish1.Name = "finish1";
            this.finish1.Size = new System.Drawing.Size(123, 52);
            this.finish1.TabIndex = 2;
            // 
            // wall2
            // 
            this.wall2.BackColor = System.Drawing.Color.PaleVioletRed;
            this.wall2.Location = new System.Drawing.Point(837, -4);
            this.wall2.Margin = new System.Windows.Forms.Padding(5);
            this.wall2.Name = "wall2";
            this.wall2.Size = new System.Drawing.Size(31, 649);
            this.wall2.TabIndex = 0;
            // 
            // wall8
            // 
            this.wall8.BackColor = System.Drawing.Color.PaleVioletRed;
            this.wall8.Location = new System.Drawing.Point(471, 372);
            this.wall8.Margin = new System.Windows.Forms.Padding(5);
            this.wall8.Name = "wall8";
            this.wall8.Size = new System.Drawing.Size(33, 247);
            this.wall8.TabIndex = 0;
            // 
            // wall7
            // 
            this.wall7.BackColor = System.Drawing.Color.PaleVioletRed;
            this.wall7.Location = new System.Drawing.Point(161, 294);
            this.wall7.Margin = new System.Windows.Forms.Padding(5);
            this.wall7.Name = "wall7";
            this.wall7.Size = new System.Drawing.Size(33, 222);
            this.wall7.TabIndex = 0;
            // 
            // wall6
            // 
            this.wall6.BackColor = System.Drawing.Color.PaleVioletRed;
            this.wall6.Location = new System.Drawing.Point(161, 274);
            this.wall6.Margin = new System.Windows.Forms.Padding(5);
            this.wall6.Name = "wall6";
            this.wall6.Size = new System.Drawing.Size(676, 26);
            this.wall6.TabIndex = 0;
            // 
            // wall5
            // 
            this.wall5.BackColor = System.Drawing.Color.PaleVioletRed;
            this.wall5.Location = new System.Drawing.Point(31, 146);
            this.wall5.Margin = new System.Windows.Forms.Padding(5);
            this.wall5.Name = "wall5";
            this.wall5.Size = new System.Drawing.Size(500, 26);
            this.wall5.TabIndex = 0;
            // 
            // wall4
            // 
            this.wall4.BackColor = System.Drawing.Color.PaleVioletRed;
            this.wall4.Location = new System.Drawing.Point(0, 0);
            this.wall4.Margin = new System.Windows.Forms.Padding(5);
            this.wall4.Name = "wall4";
            this.wall4.Size = new System.Drawing.Size(868, 26);
            this.wall4.TabIndex = 0;
            // 
            // wall3
            // 
            this.wall3.BackColor = System.Drawing.Color.PaleVioletRed;
            this.wall3.Location = new System.Drawing.Point(0, 619);
            this.wall3.Margin = new System.Windows.Forms.Padding(5);
            this.wall3.Name = "wall3";
            this.wall3.Size = new System.Drawing.Size(868, 26);
            this.wall3.TabIndex = 0;
            // 
            // wall1
            // 
            this.wall1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.wall1.Location = new System.Drawing.Point(0, 0);
            this.wall1.Margin = new System.Windows.Forms.Padding(5);
            this.wall1.Name = "wall1";
            this.wall1.Size = new System.Drawing.Size(31, 645);
            this.wall1.TabIndex = 0;
            // 
            // Level01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.Controls.Add(this.start1);
            this.Controls.Add(this.finish1);
            this.Controls.Add(this.wall2);
            this.Controls.Add(this.wall8);
            this.Controls.Add(this.wall7);
            this.Controls.Add(this.wall6);
            this.Controls.Add(this.wall5);
            this.Controls.Add(this.wall4);
            this.Controls.Add(this.wall3);
            this.Controls.Add(this.wall1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Level01";
            this.Size = new System.Drawing.Size(868, 645);
            this.ResumeLayout(false);

        }

        #endregion

        private Wall wall1;
        private Wall wall2;
        private Wall wall3;
        private Wall wall4;
        private Finish finish1;
        private Start start1;
        private Wall wall5;
        private Wall wall6;
        private Wall wall7;
        private Wall wall8;
    }
}
