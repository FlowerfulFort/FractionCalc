namespace FractionCalc
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.F1 = new System.Windows.Forms.TableLayoutPanel();
            this.F1_deno = new System.Windows.Forms.TextBox();
            this.F1_numer = new System.Windows.Forms.TextBox();
            this.oper = new System.Windows.Forms.Label();
            this.F2 = new System.Windows.Forms.TableLayoutPanel();
            this.F2_numer = new System.Windows.Forms.TextBox();
            this.F2_deno = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TableLayoutPanel();
            this.r_deno = new System.Windows.Forms.TextBox();
            this.r_numer = new System.Windows.Forms.TextBox();
            this.LEqual = new System.Windows.Forms.Label();
            this.ConvBtn = new System.Windows.Forms.Button();
            this.CalcBtn = new System.Windows.Forms.Button();
            this.setOper = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.F1.SuspendLayout();
            this.F2.SuspendLayout();
            this.Result.SuspendLayout();
            this.SuspendLayout();
            // 
            // F1
            // 
            this.F1.AutoSize = true;
            this.F1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.F1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.F1.ColumnCount = 1;
            this.F1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.F1.Controls.Add(this.F1_deno, 0, 1);
            this.F1.Controls.Add(this.F1_numer, 0, 0);
            this.F1.Location = new System.Drawing.Point(1, 1);
            this.F1.Name = "F1";
            this.F1.RowCount = 2;
            this.F1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.F1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.F1.Size = new System.Drawing.Size(65, 65);
            this.F1.TabIndex = 0;
            // 
            // F1_deno
            // 
            this.F1_deno.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.F1_deno.Location = new System.Drawing.Point(4, 38);
            this.F1_deno.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.F1_deno.Name = "F1_deno";
            this.F1_deno.Size = new System.Drawing.Size(57, 23);
            this.F1_deno.TabIndex = 1;
            // 
            // F1_numer
            // 
            this.F1_numer.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.F1_numer.Location = new System.Drawing.Point(4, 4);
            this.F1_numer.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.F1_numer.Name = "F1_numer";
            this.F1_numer.Size = new System.Drawing.Size(57, 23);
            this.F1_numer.TabIndex = 0;
            // 
            // oper
            // 
            this.oper.AutoSize = true;
            this.oper.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oper.Location = new System.Drawing.Point(85, 28);
            this.oper.Name = "oper";
            this.oper.Size = new System.Drawing.Size(0, 11);
            this.oper.TabIndex = 1;
            // 
            // F2
            // 
            this.F2.AutoSize = true;
            this.F2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.F2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.F2.ColumnCount = 1;
            this.F2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.F2.Controls.Add(this.F2_numer, 0, 0);
            this.F2.Controls.Add(this.F2_deno, 0, 1);
            this.F2.Location = new System.Drawing.Point(112, 1);
            this.F2.Name = "F2";
            this.F2.RowCount = 2;
            this.F2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.F2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.F2.Size = new System.Drawing.Size(65, 65);
            this.F2.TabIndex = 2;
            // 
            // F2_numer
            // 
            this.F2_numer.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.F2_numer.Location = new System.Drawing.Point(4, 4);
            this.F2_numer.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.F2_numer.Name = "F2_numer";
            this.F2_numer.Size = new System.Drawing.Size(57, 23);
            this.F2_numer.TabIndex = 0;
            // 
            // F2_deno
            // 
            this.F2_deno.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.F2_deno.Location = new System.Drawing.Point(4, 38);
            this.F2_deno.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.F2_deno.Name = "F2_deno";
            this.F2_deno.Size = new System.Drawing.Size(57, 23);
            this.F2_deno.TabIndex = 1;
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Result.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.Result.ColumnCount = 1;
            this.Result.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Result.Controls.Add(this.r_deno, 0, 1);
            this.Result.Controls.Add(this.r_numer, 0, 0);
            this.Result.Location = new System.Drawing.Point(259, 1);
            this.Result.Name = "Result";
            this.Result.RowCount = 2;
            this.Result.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Result.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Result.Size = new System.Drawing.Size(65, 65);
            this.Result.TabIndex = 3;
            // 
            // r_deno
            // 
            this.r_deno.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.r_deno.Location = new System.Drawing.Point(4, 38);
            this.r_deno.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.r_deno.Name = "r_deno";
            this.r_deno.Size = new System.Drawing.Size(57, 23);
            this.r_deno.TabIndex = 1;
            // 
            // r_numer
            // 
            this.r_numer.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.r_numer.Location = new System.Drawing.Point(4, 4);
            this.r_numer.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.r_numer.Name = "r_numer";
            this.r_numer.Size = new System.Drawing.Size(57, 23);
            this.r_numer.TabIndex = 0;
            // 
            // LEqual
            // 
            this.LEqual.AutoSize = true;
            this.LEqual.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.LEqual.Location = new System.Drawing.Point(214, 24);
            this.LEqual.Name = "LEqual";
            this.LEqual.Size = new System.Drawing.Size(15, 15);
            this.LEqual.TabIndex = 4;
            this.LEqual.Text = "=";
            // 
            // ConvBtn
            // 
            this.ConvBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ConvBtn.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ConvBtn.Location = new System.Drawing.Point(168, 102);
            this.ConvBtn.Name = "ConvBtn";
            this.ConvBtn.Size = new System.Drawing.Size(160, 23);
            this.ConvBtn.TabIndex = 5;
            this.ConvBtn.Text = "기약분수로 전환하기";
            this.ConvBtn.UseVisualStyleBackColor = true;
            this.ConvBtn.Click += new System.EventHandler(this.ConvBtn_Click);
            // 
            // CalcBtn
            // 
            this.CalcBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CalcBtn.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CalcBtn.Location = new System.Drawing.Point(5, 102);
            this.CalcBtn.Name = "CalcBtn";
            this.CalcBtn.Size = new System.Drawing.Size(160, 23);
            this.CalcBtn.TabIndex = 6;
            this.CalcBtn.Text = "계산";
            this.CalcBtn.UseVisualStyleBackColor = true;
            this.CalcBtn.Click += new System.EventHandler(this.calcButtonEvn);
            // 
            // setOper
            // 
            this.setOper.Cursor = System.Windows.Forms.Cursors.Default;
            this.setOper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.setOper.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.setOper.FormattingEnabled = true;
            this.setOper.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.setOper.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.setOper.Location = new System.Drawing.Point(63, 73);
            this.setOper.Name = "setOper";
            this.setOper.Size = new System.Drawing.Size(65, 23);
            this.setOper.TabIndex = 8;
            this.setOper.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "연산자:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(347, 134);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.setOper);
            this.Controls.Add(this.CalcBtn);
            this.Controls.Add(this.ConvBtn);
            this.Controls.Add(this.LEqual);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.F2);
            this.Controls.Add(this.oper);
            this.Controls.Add(this.F1);
            this.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "분수계산기";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.F1.ResumeLayout(false);
            this.F1.PerformLayout();
            this.F2.ResumeLayout(false);
            this.F2.PerformLayout();
            this.Result.ResumeLayout(false);
            this.Result.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel F1;
        private System.Windows.Forms.TextBox F1_deno;
        private System.Windows.Forms.TextBox F1_numer;
        private System.Windows.Forms.Label oper;
        private System.Windows.Forms.TableLayoutPanel F2;
        private System.Windows.Forms.TextBox F2_numer;
        private System.Windows.Forms.TextBox F2_deno;
        private System.Windows.Forms.TableLayoutPanel Result;
        private System.Windows.Forms.TextBox r_deno;
        private System.Windows.Forms.TextBox r_numer;
        private System.Windows.Forms.Label LEqual;
        private System.Windows.Forms.Button ConvBtn;
        private System.Windows.Forms.Button CalcBtn;
        private System.Windows.Forms.ComboBox setOper;
        private System.Windows.Forms.Label label2;
    }
}