using System;
using System.Drawing;
using System.Windows.Forms;
using Tesseract;

namespace OCR
{
	public partial class frmOcr : Form
	{
		public frmOcr()
		{
			InitializeComponent();
		}

		private void btnGetText_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;

			// 이미지 객체 로드
			Bitmap bitmap = new Bitmap(this.pic.Image);

			// 테서렉트 엔진 생성 (생성자에서 영문자 데이터 학습경로 설정)
			var ocr = new TesseractEngine("./tessdata", "eng", EngineMode.TesseractAndCube);
			// 이미지 분석
			var texts = ocr.Process(bitmap);
			// 결과데이터 텍스트박스에 출력
			this.txt.Text = texts.GetText();
			//MessageBox.Show(texts.GetText());


			Cursor.Current = Cursors.Default;
		}

		private void btnGetTextKor_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;

			// 이미지 객체 로드
			Bitmap bitmap = new Bitmap(this.pic.Image);

			// 테서렉트 엔진 생성 (생성자에서 영문자 데이터 학습경로 설정)
			var ocr = new TesseractEngine("./tessdata", "kor", EngineMode.Default);
			// 이미지 분석
			var texts = ocr.Process(bitmap);
			// 결과데이터 텍스트박스에 출력
			this.txt.Text = texts.GetText();
			//MessageBox.Show(texts.GetText());


			Cursor.Current = Cursors.Default;
		}

		private void frmOcr_Load(object sender, EventArgs e)
		{
			
		}

		private void btnChangeImage_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog dialog = new OpenFileDialog())
			{
				dialog.InitialDirectory = Application.StartupPath;
				dialog.RestoreDirectory = true;

				if (dialog.ShowDialog() == DialogResult.OK)
				{
					this.pic.Image = Image.FromFile(dialog.FileName);
				}
			}
		}
	}
}
