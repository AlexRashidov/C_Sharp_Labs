namespace PredictorApp
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
            this.predictionButton = new System.Windows.Forms.Button();
            this.predictionLabel = new System.Windows.Forms.Label();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.userProbabilityTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.predictionButtonX = new System.Windows.Forms.Button();
            this.predictionButtonY = new System.Windows.Forms.Button();
            this.answer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // predictionButton
            // 
            this.predictionButton.Location = new System.Drawing.Point(15, 205);
            this.predictionButton.Name = "predictionButton";
            this.predictionButton.Size = new System.Drawing.Size(113, 41);
            this.predictionButton.TabIndex = 0;
            this.predictionButton.Text = "Равновероятно";
            this.predictionButton.UseVisualStyleBackColor = true;
            this.predictionButton.Click += new System.EventHandler(this.predictionButton_Click);
            // 
            // predictionLabel
            // 
            this.predictionLabel.AutoSize = true;
            this.predictionLabel.Location = new System.Drawing.Point(12, 189);
            this.predictionLabel.Name = "predictionLabel";
            this.predictionLabel.Size = new System.Drawing.Size(0, 13);
            this.predictionLabel.TabIndex = 1;
            this.predictionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // questionTextBox
            // 
            this.questionTextBox.Location = new System.Drawing.Point(12, 22);
            this.questionTextBox.Multiline = true;
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.Size = new System.Drawing.Size(363, 152);
            this.questionTextBox.TabIndex = 2;
            // 
            // userProbabilityTextBox
            // 
            this.userProbabilityTextBox.Location = new System.Drawing.Point(100, 380);
            this.userProbabilityTextBox.Name = "userProbabilityTextBox";
            this.userProbabilityTextBox.Size = new System.Drawing.Size(100, 20);
            this.userProbabilityTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Вероятность x = ";
            // 
            // predictionButtonX
            // 
            this.predictionButtonX.Location = new System.Drawing.Point(143, 205);
            this.predictionButtonX.Name = "predictionButtonX";
            this.predictionButtonX.Size = new System.Drawing.Size(113, 41);
            this.predictionButtonX.TabIndex = 5;
            this.predictionButtonX.Text = "Вероятность Х";
            this.predictionButtonX.UseVisualStyleBackColor = true;
            this.predictionButtonX.Click += new System.EventHandler(this.predictionButtonX_Click);
            // 
            // predictionButtonY
            // 
            this.predictionButtonY.Location = new System.Drawing.Point(262, 205);
            this.predictionButtonY.Name = "predictionButtonY";
            this.predictionButtonY.Size = new System.Drawing.Size(113, 41);
            this.predictionButtonY.TabIndex = 6;
            this.predictionButtonY.Text = "Вероятность У";
            this.predictionButtonY.UseVisualStyleBackColor = true;
            this.predictionButtonY.Click += new System.EventHandler(this.predictionButtonY_Click);
            // 
            // answer
            // 
            this.answer.Location = new System.Drawing.Point(143, 425);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(100, 20);
            this.answer.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Слово для вероятности - ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 467);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.predictionButtonY);
            this.Controls.Add(this.predictionButtonX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userProbabilityTextBox);
            this.Controls.Add(this.questionTextBox);
            this.Controls.Add(this.predictionLabel);
            this.Controls.Add(this.predictionButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button predictionButton;
        private System.Windows.Forms.Label predictionLabel;
        private System.Windows.Forms.TextBox questionTextBox;
        public System.Windows.Forms.TextBox userProbabilityTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button predictionButtonX;
        private System.Windows.Forms.Button predictionButtonY;
        public System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.Label label2;
    }
}

