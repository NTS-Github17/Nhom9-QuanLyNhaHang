using BUS;
using DTO;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmProduct : Form
    {
        private string fileAddress;
        private byte[] img;
        BUS_Product busProduct = new BUS_Product();
        DTO_Product dtoProduct;

        public frmProduct()
        {
            InitializeComponent();
        }

        private void SetValue(bool param, bool isLoad)
        {
            txtMaSp.Text = null;
            txtTenSP.Text = null;
            txtDonViTinh.Text = null;
            txtGiaBan.Text = null;
            txtDonGia.Text = null;
            txtChiecKhau.Text = null;
            txtVAT.Text = null;
            btnInsert.Enabled = param;
            pcbProduct.Image = null;
            if (isLoad)
            {
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                btnUpdate.Enabled = !param;
                btnDelete.Enabled = !param;
            }
        }

        private void MsgBox(string message, bool isError = false)
        {
            if (isError)
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private Image CloneImage(string path)
        {
            Image result;
            using (Bitmap original = new Bitmap(path))
            {
                result = (Bitmap)original.Clone();

            };
            return result;
        }

        private byte[] ImageToByteArray(PictureBox pictureBox)
        {
            MemoryStream memoryStream = new MemoryStream();
            pictureBox.Image.Save(memoryStream, pictureBox.Image.RawFormat);
            return memoryStream.ToArray();
        }

        private void LoadGridView()
        {
            gvProduct.Columns[0].HeaderText = "Mã hàng";
            gvProduct.Columns[1].HeaderText = "Tên hàng";
            gvProduct.Columns[2].HeaderText = "Số lượng";
            gvProduct.Columns[3].HeaderText = "Đơn giá nhập";
            gvProduct.Columns[4].HeaderText = "Đơn giá bán";
            gvProduct.Columns[5].HeaderText = "Hình ảnh";
            gvProduct.Columns[6].HeaderText = "Ghi chú";
            foreach (DataGridViewColumn item in gvProduct.Columns)
                item.DividerWidth = 1;

            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol = (DataGridViewImageColumn)gvProduct.Columns[5];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            
            gvProduct.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gvProduct.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gvProduct.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gvProduct.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private bool CheckIsNummber(string text)
        {
            return int.TryParse(text, out int s);
        }

        private void OpenImage()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            open.Title = "Chọn ảnh";
            if (open.ShowDialog() == DialogResult.OK)
            {
                fileAddress = open.FileName;
                pcbProduct.Image = CloneImage(fileAddress);
                pcbProduct.ImageLocation = fileAddress;
                img = ImageToByteArray(pcbProduct);
            }
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            gvProduct.DataSource = busProduct.ListOfProducts();
            LoadGridView();
            SetValue(true, false);
            txtTenSP.Focus();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!CheckIsNummber(txtDonViTinh.Text) || !CheckIsNummber(txtGiaBan.Text) || !CheckIsNummber(txtDonGia.Text))
                MsgBox("Vui lòng nhập chữ số!", true);
            else if (txtTenSP.Text == "")
                MsgBox("Thiếu trường thông tin!", true);
            else if (pcbProduct.Image == null)
                MsgBox("Vui lòng chọn hình!", true);
            else
            {
                dtoProduct = new DTO_Product
                (
                    txtTenSP.Text,
                    int.Parse(txtDonViTinh.Text),
                    int.Parse(txtDonGia.Text),
                    int.Parse(txtGiaBan.Text),
                    ImageToByteArray(pcbProduct)                
                );
                if (busProduct.InsertProduct(dtoProduct))
                {
                    gvProduct.DataSource = busProduct.ListOfProducts();
                    LoadGridView();
                    MsgBox("Thêm sản phẩm thành công");
                }
                else
                {
                    MsgBox("Thêm sản phẩm không được", true);
                }
            }
        }

        private void btnInsertPicture_Click(object sender, EventArgs e)
        {
            OpenImage();
        }

        private void gvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gvProduct.Rows.Count > 0)
            {
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;

                txtMaSp.ReadOnly = true;
                txtMaSp.Text = gvProduct.CurrentRow.Cells[0].Value.ToString();
                txtTenSP.Text = gvProduct.CurrentRow.Cells[1].Value.ToString();
                txtDonViTinh.Text = gvProduct.CurrentRow.Cells[2].Value.ToString();
                txtDonGia.Text = gvProduct.CurrentRow.Cells[3].Value.ToString();
                txtGiaBan.Text = gvProduct.CurrentRow.Cells[4].Value.ToString();
                
                MemoryStream memoryStream = new MemoryStream((byte[])gvProduct.CurrentRow.Cells[5].Value);
                pcbProduct.Image = Image.FromStream(memoryStream);
                
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn sửa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!CheckIsNummber(txtDonViTinh.Text) || !CheckIsNummber(txtGiaBan.Text) || !CheckIsNummber(txtDonGia.Text))
                    MsgBox("Vui lòng nhập chữ số!", true);
                else if (txtTenSP.Text == "")
                    MsgBox("Thiếu trường thông tin!", true);
                else if (pcbProduct.Image == null)
                    MsgBox("Vui lòng chọn hình!", true);
                else
                {
                    dtoProduct = new DTO_Product
                    (
                        int.Parse(txtMaSp.Text),
                        txtTenSP.Text,
                        int.Parse(txtDonViTinh.Text),
                        int.Parse(txtDonGia.Text),
                        int.Parse(txtGiaBan.Text),
                        ImageToByteArray(pcbProduct),

                    ) ;
                    if (busProduct.UpdateProduct(dtoProduct))
                    {
                        gvProduct.DataSource = busProduct.ListOfProducts();
                        LoadGridView();
                        MsgBox("Sửa sản phẩm thành công!");
                    }
                    else
                    {
                        MsgBox("Sửa sản phẩm không được", true);
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (busProduct.DeleteProduct(int.Parse(txtMaSp.Text)))
                {
                    gvProduct.DataSource = busProduct.ListOfProducts();
                    LoadGridView();
                    MsgBox("Xóa thành công");
                }
                else
                    MsgBox("Xóa không thành công!");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SetValue(true, false);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string name = txtSearch.Text.Trim();
            if (name == "")
            {
                frmProduct_Load(sender, e);
                txtSearch.Focus();
            }
            else
            {
                DataTable data = busProduct.SearchProduct(txtSearch.Text);
                gvProduct.DataSource = data;
            }
        }

        private void gvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pcbProduct_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtGiaBan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtVAT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
