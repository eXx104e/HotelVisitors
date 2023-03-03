using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Hotel_Visitors
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
            this.components = new System.ComponentModel.Container();
            this.buttonInfoGuest = new System.Windows.Forms.Button();
            this.labelTimeNow = new System.Windows.Forms.Label();
            this.timerForLabel = new System.Windows.Forms.Timer(this.components);
            this.labelStatusRoom = new System.Windows.Forms.Label();
            this.labelListGuest = new System.Windows.Forms.Label();
            this.labelGuestStatus = new System.Windows.Forms.Label();
            this.labelDateOfDeparture1 = new System.Windows.Forms.Label();
            this.labelDateArrival1 = new System.Windows.Forms.Label();
            this.textBoxSearchGuest = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelNumberGuest = new System.Windows.Forms.Label();
            this.checkedListBoxStatus = new System.Windows.Forms.CheckedListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonSearchStatuses = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewGuest = new System.Windows.Forms.DataGridView();
            this.labelStatusGuestView = new System.Windows.Forms.Label();
            this.labelDateOfDeparture2 = new System.Windows.Forms.Label();
            this.labelDateArrival2 = new System.Windows.Forms.Label();
            this.pictureBoxGuest = new System.Windows.Forms.PictureBox();
            this.labelGuestFIO = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBoxTime = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGuest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGuest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTime)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonInfoGuest
            // 
            this.buttonInfoGuest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfoGuest.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonInfoGuest.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInfoGuest.Location = new System.Drawing.Point(157, 504);
            this.buttonInfoGuest.Name = "buttonInfoGuest";
            this.buttonInfoGuest.Size = new System.Drawing.Size(123, 28);
            this.buttonInfoGuest.TabIndex = 0;
            this.buttonInfoGuest.Text = "Просмотр карточки";
            this.buttonInfoGuest.UseVisualStyleBackColor = true;
            this.buttonInfoGuest.Click += new System.EventHandler(this.buttonInfoGuest_Click);
            // 
            // labelTimeNow
            // 
            this.labelTimeNow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTimeNow.AutoSize = true;
            this.labelTimeNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimeNow.Location = new System.Drawing.Point(45, 6);
            this.labelTimeNow.Name = "labelTimeNow";
            this.labelTimeNow.Size = new System.Drawing.Size(181, 32);
            this.labelTimeNow.TabIndex = 8;
            this.labelTimeNow.Text = "01:01:01 мск";
            // 
            // timerForLabel
            // 
            this.timerForLabel.Tick += new System.EventHandler(this.timerForLabel_Tick);
            // 
            // labelStatusRoom
            // 
            this.labelStatusRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelStatusRoom.AutoSize = true;
            this.labelStatusRoom.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatusRoom.Location = new System.Drawing.Point(57, 20);
            this.labelStatusRoom.Name = "labelStatusRoom";
            this.labelStatusRoom.Size = new System.Drawing.Size(133, 36);
            this.labelStatusRoom.TabIndex = 10;
            this.labelStatusRoom.Text = "Condition";
            // 
            // labelListGuest
            // 
            this.labelListGuest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelListGuest.AutoSize = true;
            this.labelListGuest.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelListGuest.Location = new System.Drawing.Point(214, 20);
            this.labelListGuest.Name = "labelListGuest";
            this.labelListGuest.Size = new System.Drawing.Size(136, 36);
            this.labelListGuest.TabIndex = 11;
            this.labelListGuest.Text = "Guest List";
            // 
            // labelGuestStatus
            // 
            this.labelGuestStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGuestStatus.AutoSize = true;
            this.labelGuestStatus.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGuestStatus.ImageKey = "(отсутствует)";
            this.labelGuestStatus.Location = new System.Drawing.Point(10, 293);
            this.labelGuestStatus.Name = "labelGuestStatus";
            this.labelGuestStatus.Size = new System.Drawing.Size(88, 20);
            this.labelGuestStatus.TabIndex = 17;
            this.labelGuestStatus.Text = "Condition:  ";
            // 
            // labelDateOfDeparture1
            // 
            this.labelDateOfDeparture1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDateOfDeparture1.AutoSize = true;
            this.labelDateOfDeparture1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateOfDeparture1.Location = new System.Drawing.Point(9, 420);
            this.labelDateOfDeparture1.Name = "labelDateOfDeparture1";
            this.labelDateOfDeparture1.Size = new System.Drawing.Size(102, 22);
            this.labelDateOfDeparture1.TabIndex = 20;
            this.labelDateOfDeparture1.Text = "Eviction date:";
            // 
            // labelDateArrival1
            // 
            this.labelDateArrival1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDateArrival1.AutoSize = true;
            this.labelDateArrival1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateArrival1.Location = new System.Drawing.Point(9, 347);
            this.labelDateArrival1.Name = "labelDateArrival1";
            this.labelDateArrival1.Size = new System.Drawing.Size(108, 22);
            this.labelDateArrival1.TabIndex = 21;
            this.labelDateArrival1.Text = "Check-in date:";
            // 
            // textBoxSearchGuest
            // 
            this.textBoxSearchGuest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxSearchGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearchGuest.Location = new System.Drawing.Point(311, 6);
            this.textBoxSearchGuest.Name = "textBoxSearchGuest";
            this.textBoxSearchGuest.Size = new System.Drawing.Size(456, 26);
            this.textBoxSearchGuest.TabIndex = 14;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSearch.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch.Location = new System.Drawing.Point(766, 6);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(80, 26);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelNumberGuest
            // 
            this.labelNumberGuest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelNumberGuest.AutoSize = true;
            this.labelNumberGuest.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumberGuest.Location = new System.Drawing.Point(26, 20);
            this.labelNumberGuest.Name = "labelNumberGuest";
            this.labelNumberGuest.Size = new System.Drawing.Size(249, 36);
            this.labelNumberGuest.TabIndex = 12;
            this.labelNumberGuest.Text = "Guest number -       ";
            // 
            // checkedListBoxStatus
            // 
            this.checkedListBoxStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkedListBoxStatus.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkedListBoxStatus.FormattingEnabled = true;
            this.checkedListBoxStatus.Items.AddRange(new object[] {
            "Зарезервировал",
            "Свободен",
            "Занят",
            "Выписывается"});
            this.checkedListBoxStatus.Location = new System.Drawing.Point(18, 72);
            this.checkedListBoxStatus.Name = "checkedListBoxStatus";
            this.checkedListBoxStatus.Size = new System.Drawing.Size(191, 80);
            this.checkedListBoxStatus.TabIndex = 6;
            this.checkedListBoxStatus.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxStatus_SelectedIndexChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(0, 50);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonSearchStatuses);
            this.splitContainer1.Panel1.Controls.Add(this.checkedListBoxStatus);
            this.splitContainer1.Panel1.Controls.Add(this.labelStatusRoom);
            this.splitContainer1.Panel1MinSize = 230;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2MinSize = 810;
            this.splitContainer1.Size = new System.Drawing.Size(1097, 545);
            this.splitContainer1.SplitterDistance = 230;
            this.splitContainer1.TabIndex = 22;
            // 
            // buttonSearchStatuses
            // 
            this.buttonSearchStatuses.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSearchStatuses.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSearchStatuses.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearchStatuses.Location = new System.Drawing.Point(18, 158);
            this.buttonSearchStatuses.Name = "buttonSearchStatuses";
            this.buttonSearchStatuses.Size = new System.Drawing.Size(191, 36);
            this.buttonSearchStatuses.TabIndex = 11;
            this.buttonSearchStatuses.Text = "Search";
            this.buttonSearchStatuses.UseVisualStyleBackColor = false;
            this.buttonSearchStatuses.Click += new System.EventHandler(this.buttonSearchStatuses_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Location = new System.Drawing.Point(3, -1);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dataGridViewGuest);
            this.splitContainer2.Panel1.Controls.Add(this.labelListGuest);
            this.splitContainer2.Panel1MinSize = 400;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.labelStatusGuestView);
            this.splitContainer2.Panel2.Controls.Add(this.labelDateOfDeparture2);
            this.splitContainer2.Panel2.Controls.Add(this.labelDateArrival2);
            this.splitContainer2.Panel2.Controls.Add(this.buttonInfoGuest);
            this.splitContainer2.Panel2.Controls.Add(this.pictureBoxGuest);
            this.splitContainer2.Panel2.Controls.Add(this.labelNumberGuest);
            this.splitContainer2.Panel2.Controls.Add(this.labelDateOfDeparture1);
            this.splitContainer2.Panel2.Controls.Add(this.labelGuestStatus);
            this.splitContainer2.Panel2.Controls.Add(this.labelGuestFIO);
            this.splitContainer2.Panel2.Controls.Add(this.labelDateArrival1);
            this.splitContainer2.Panel2MinSize = 290;
            this.splitContainer2.Size = new System.Drawing.Size(859, 545);
            this.splitContainer2.SplitterDistance = 560;
            this.splitContainer2.TabIndex = 1;
            // 
            // dataGridViewGuest
            // 
            this.dataGridViewGuest.AllowUserToAddRows = false;
            this.dataGridViewGuest.AllowUserToDeleteRows = false;
            this.dataGridViewGuest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewGuest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGuest.Location = new System.Drawing.Point(0, 76);
            this.dataGridViewGuest.Name = "dataGridViewGuest";
            this.dataGridViewGuest.ReadOnly = true;
            this.dataGridViewGuest.Size = new System.Drawing.Size(556, 468);
            this.dataGridViewGuest.TabIndex = 12;
            this.dataGridViewGuest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGuest_CellContentClick_1);
            // 
            // labelStatusGuestView
            // 
            this.labelStatusGuestView.AutoSize = true;
            this.labelStatusGuestView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelStatusGuestView.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatusGuestView.Location = new System.Drawing.Point(84, 289);
            this.labelStatusGuestView.Name = "labelStatusGuestView";
            this.labelStatusGuestView.Size = new System.Drawing.Size(102, 26);
            this.labelStatusGuestView.TabIndex = 24;
            this.labelStatusGuestView.Text = "                  ";
            // 
            // labelDateOfDeparture2
            // 
            this.labelDateOfDeparture2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDateOfDeparture2.AutoSize = true;
            this.labelDateOfDeparture2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDateOfDeparture2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateOfDeparture2.Location = new System.Drawing.Point(133, 416);
            this.labelDateOfDeparture2.Name = "labelDateOfDeparture2";
            this.labelDateOfDeparture2.Size = new System.Drawing.Size(122, 27);
            this.labelDateOfDeparture2.TabIndex = 23;
            this.labelDateOfDeparture2.Text = "                  ";
            // 
            // labelDateArrival2
            // 
            this.labelDateArrival2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDateArrival2.AutoSize = true;
            this.labelDateArrival2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDateArrival2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateArrival2.Location = new System.Drawing.Point(133, 343);
            this.labelDateArrival2.Name = "labelDateArrival2";
            this.labelDateArrival2.Size = new System.Drawing.Size(122, 27);
            this.labelDateArrival2.TabIndex = 22;
            this.labelDateArrival2.Text = "                  ";
            // 
            // pictureBoxGuest
            // 
            this.pictureBoxGuest.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxGuest.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxGuest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxGuest.Location = new System.Drawing.Point(32, 76);
            this.pictureBoxGuest.Name = "pictureBoxGuest";
            this.pictureBoxGuest.Size = new System.Drawing.Size(233, 155);
            this.pictureBoxGuest.TabIndex = 16;
            this.pictureBoxGuest.TabStop = false;
            // 
            // labelGuestFIO
            // 
            this.labelGuestFIO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelGuestFIO.AutoSize = true;
            this.labelGuestFIO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelGuestFIO.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelGuestFIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGuestFIO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelGuestFIO.Location = new System.Drawing.Point(5, 248);
            this.labelGuestFIO.Name = "labelGuestFIO";
            this.labelGuestFIO.Size = new System.Drawing.Size(279, 22);
            this.labelGuestFIO.TabIndex = 19;
            this.labelGuestFIO.Text = "                                                                   ";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBoxTime
            // 
            this.pictureBoxTime.Image = global::Hotel_Visitors.Properties.Resources.иконка_часов1;
            this.pictureBoxTime.Location = new System.Drawing.Point(12, 6);
            this.pictureBoxTime.Name = "pictureBoxTime";
            this.pictureBoxTime.Size = new System.Drawing.Size(36, 32);
            this.pictureBoxTime.TabIndex = 9;
            this.pictureBoxTime.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1097, 595);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearchGuest);
            this.Controls.Add(this.pictureBoxTime);
            this.Controls.Add(this.labelTimeNow);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Hotel_Visitors.Properties.Settings.Default, "", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.MinimumSize = new System.Drawing.Size(1113, 634);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGuest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGuest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button buttonInfoGuest;
        private System.Windows.Forms.Label labelTimeNow;
        private System.Windows.Forms.Timer timerForLabel;
        private System.Windows.Forms.Label labelStatusRoom;
        private System.Windows.Forms.Label labelListGuest;
        private System.Windows.Forms.PictureBox pictureBoxGuest;
        private System.Windows.Forms.Label labelGuestStatus;
        private System.Windows.Forms.Label labelGuestFIO;
        private System.Windows.Forms.Label labelDateOfDeparture1;
        private System.Windows.Forms.Label labelDateArrival1;
        private System.Windows.Forms.TextBox textBoxSearchGuest;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.PictureBox pictureBoxTime;
        private System.Windows.Forms.CheckedListBox checkedListBoxStatus;
        private System.Windows.Forms.Label labelNumberGuest;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label labelDateArrival2;
        private System.Windows.Forms.Label labelDateOfDeparture2;
        private System.Windows.Forms.Button buttonSearchStatuses;
        private System.Windows.Forms.Label labelStatusGuestView;
        private ImageList imageList1;
        private DataGridView dataGridViewGuest;
    }
}

