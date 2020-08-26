/// <summary>
/// Make train data for YOLOv4
/// Pick graph (manual) and save bound of the graphs
/// @Author Chanwoo Gwon, Yonsei University Researcher, since 2020.05
/// @Date 2020.08.
/// </summary>

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GraphMarker {
	#region Form

	/// <summary>
	/// Main Form
	/// </summary>
	public partial class FormMain : Form {
		/// <summary>
		/// information of graph image
		/// </summary>
		class GraphImageInfo {
			/// <summary>
			/// graphs' bound list from origin image
			/// </summary>
			private List<Rectangle> bound = new List<Rectangle>();

			/// <summary>
			/// image file name
			/// </summary>
			public string Name { get; set; }

			/// <summary>
			/// image full path
			/// </summary>
			public string FullName { get; set; }

			public List<Rectangle> Bound { get { return this.bound; } }

			public override string ToString() {
				return this.Name;
			}
		}

		#region field

		/// <summary>
		/// clicked point position
		/// </summary>
		private Point selectedPoint = default(Point);

		/// <summary>
		/// now selecting
		/// </summary>
		private bool selecting = false;

		#endregion

		#region method

		/// <summary>
		/// constructor
		/// </summary>
		public FormMain() {
			InitializeComponent();
		}

		/// <summary>
		/// Initialize informatin of clicked point
		/// </summary>
		private void initPoint() {
			this.selectedPoint = default(Point);
			this.selecting = false;
		}

		/// <summary>
		/// Draw rectangle using bound list of current image
		/// </summary>
		private void drawRect() {
			GraphImageInfo item = this.lbImageList.SelectedItem as GraphImageInfo;

			if (this.pbReadImage.BackgroundImage != null) {
				this.pbReadImage.BackgroundImage.Dispose();
			}

			Graphics grapics = this.pbReadImage.CreateGraphics();

			grapics.DrawImage(new Bitmap(new Bitmap(item.FullName), this.pbReadImage.Size), Point.Empty);
			if (item.Bound.Count > 0) {

				foreach (Rectangle rect in item.Bound) {
					grapics.DrawRectangle(Pens.Black, rect);
				}
			}
		}
		
		/// <summary>
		/// save all image information
		/// </summary>
		private void saveImage() {
			if (this.pbReadImage.BackgroundImage != null) {
				pbReadImage.BackgroundImage.Dispose();
			}

			string text = "";

			for (int i =0;i<this.lbImageList.Items.Count;i++) {
				GraphImageInfo info = this.lbImageList.Items[i] as GraphImageInfo;

				text += info.Name;

				foreach (Rectangle rect in info.Bound) {
					text += " " + rect.X + "," + rect.Y + "," + (rect.X + rect.Width) + 
						"," + (rect.Y + rect.Height) + ",0";
				}

				text += "\n";

				Bitmap resized = new Bitmap(new Bitmap(info.FullName), this.pbReadImage.Size);
				resized.Save("./" + info.Name);
			}

			using (StreamWriter writer = new StreamWriter("./all.txt")) {
				writer.Write(text);
			}
		}

		#endregion

		#region event handler
		private void btnSave_Click(object sender, EventArgs e) {
			this.saveImage();
		}

		private void btnFolder_Click(object sender, EventArgs e) {
			FolderBrowserDialog dialog = new FolderBrowserDialog();
			DialogResult res = dialog.ShowDialog();

			if (res == DialogResult.OK || res == DialogResult.Yes) {
				string dir = dialog.SelectedPath;
				this.tbFolderName.Text = dir;

				string[] childList = Directory.GetFiles(dir);

				foreach (string child in childList) {
					FileInfo info = new FileInfo(child);

					if (info.Extension == ".png") {
						this.lbImageList.Items.Add(new GraphImageInfo() {
							Name = info.Name,
							FullName = info.FullName
						});
					}
				}
			}
		}

		private void lbImageList_SelectedIndexChanged(object sender, EventArgs e) {
			this.initPoint();
			this.drawRect();
		}

		private void pbReadImage_Click(object sender, EventArgs e) {
			GraphImageInfo info = this.lbImageList.SelectedItem as GraphImageInfo;

			if (info == null)
				return;
			
			if (!selecting) {
				Point pt = Cursor.Position;
				this.selectedPoint = this.pbReadImage.PointToClient(pt);

				selecting = true;
			} else {
				Point pt = Cursor.Position;
				Point pt2 = this.pbReadImage.PointToClient(pt);
				Rectangle rect = new Rectangle(this.selectedPoint, new Size(pt2.X - this.selectedPoint.X, pt2.Y - this.selectedPoint.Y)); ;

				info.Bound.Add(rect);
				
				this.initPoint();
				this.drawRect();
			}
		}

		private void btnInit_Click(object sender, EventArgs e) {
			GraphImageInfo info = this.lbImageList.SelectedItem as GraphImageInfo;

			if (info == null)
				return;

			info.Bound.Clear();
			this.initPoint();
			this.drawRect();
		}
		#endregion
	}

	#endregion
}
