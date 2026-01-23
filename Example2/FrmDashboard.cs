using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ADO_Example
{
    public partial class FrmDashboard : Form
    {
        // Các Label để update số liệu
        private Label lblBuildingCount = new Label();
        private Label lblCustomerCount = new Label();
        private Label lblRevenue = new Label();
        private Label lblContractCount = new Label();

        public FrmDashboard()
        {
            InitializeComponent();
            DesignResponsiveDashboard(); // Dùng hàm thiết kế mới
            LoadRealData();
        }

        // --- HÀM THIẾT KẾ MỚI (DÙNG TABLE LAYOUT) ---
        private void DesignResponsiveDashboard()
        {
            this.BackColor = Color.FromArgb(245, 247, 250);
            this.Padding = new Padding(20); // Khoảng cách với viền form

            // 1. LAYOUT CHÍNH (Chia làm 3 dòng: Header, Cards, Body)
            TableLayoutPanel tlpMain = new TableLayoutPanel();
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.ColumnCount = 1;
            tlpMain.RowCount = 3;
            // Dòng 1: Header (80px), Dòng 2: Cards (180px), Dòng 3: Còn lại
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 180F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.Controls.Add(tlpMain);

            // --- A. HEADER (Dòng 1) ---
            Panel pnlHeader = new Panel { Dock = DockStyle.Fill };
            Label lblTitle = new Label
            {
                Text = "TỔNG QUAN HỆ THỐNG",
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                ForeColor = Color.FromArgb(24, 30, 54),
                AutoSize = true,
                Location = new Point(0, 10)
            };
            Label lblSub = new Label
            {
                Text = "Cập nhật dữ liệu thời gian thực: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"),
                Font = new Font("Segoe UI", 10, FontStyle.Italic),
                ForeColor = Color.Gray,
                AutoSize = true,
                Location = new Point(3, 45)
            };
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblSub);
            tlpMain.Controls.Add(pnlHeader, 0, 0);

            // --- B. CARDS (Dòng 2 - Chia 4 cột đều nhau) ---
            TableLayoutPanel tlpCards = new TableLayoutPanel();
            tlpCards.Dock = DockStyle.Fill;
            tlpCards.ColumnCount = 4;
            tlpCards.RowCount = 1;
            // Mỗi cột chiếm 25%
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));

            // Thêm 4 thẻ vào 4 cột (Kèm padding để tạo khe hở)
            tlpCards.Controls.Add(CreateResponsiveCard("TÒA NHÀ", "...", "🏢", Color.FromArgb(108, 92, 231), ref lblBuildingCount), 0, 0);
            tlpCards.Controls.Add(CreateResponsiveCard("KHÁCH HÀNG", "...", "👥", Color.FromArgb(253, 121, 168), ref lblCustomerCount), 1, 0);
            tlpCards.Controls.Add(CreateResponsiveCard("DOANH THU", "...", "💰", Color.FromArgb(0, 184, 148), ref lblRevenue), 2, 0);
            tlpCards.Controls.Add(CreateResponsiveCard("HỢP ĐỒNG", "...", "📝", Color.FromArgb(225, 112, 85), ref lblContractCount), 3, 0);

            tlpMain.Controls.Add(tlpCards, 0, 1);

            // --- C. BODY (Dòng 3 - Chia 2 phần: Biểu đồ 65% - List 35%) ---
            TableLayoutPanel tlpBody = new TableLayoutPanel();
            tlpBody.Dock = DockStyle.Fill;
            tlpBody.ColumnCount = 2;
            tlpBody.RowCount = 1;
            tlpBody.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F)); // Biểu đồ rộng hơn
            tlpBody.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tlpBody.Padding = new Padding(0, 20, 0, 0); // Cách bên trên 20px

            // C.1 Biểu đồ
            Panel pnlChartContainer = new Panel { Dock = DockStyle.Fill, BackColor = Color.White, Padding = new Padding(10) };
            Chart revenueChart = CreateRevenueChart();
            revenueChart.Dock = DockStyle.Fill;
            Label lblChartTitle = new Label { Text = "BIỂU ĐỒ DOANH THU", Font = new Font("Segoe UI", 11, FontStyle.Bold), Dock = DockStyle.Top, Height = 30, ForeColor = Color.DimGray };
            pnlChartContainer.Controls.Add(revenueChart);
            pnlChartContainer.Controls.Add(lblChartTitle);

            // Wrapper để tạo khoảng cách
            Panel pnlChartWrapper = new Panel { Dock = DockStyle.Fill, Padding = new Padding(0, 0, 10, 0) }; // Hở bên phải 10px
            pnlChartWrapper.Controls.Add(pnlChartContainer);
            tlpBody.Controls.Add(pnlChartWrapper, 0, 0);

            // C.2 Danh sách
            Panel pnlListContainer = new Panel { Dock = DockStyle.Fill, BackColor = Color.White, Padding = new Padding(10) };
            DataGridView dgvRecent = new DataGridView();
            StyleRecentGrid(dgvRecent);
            dgvRecent.Dock = DockStyle.Fill;
            LoadRecentContracts(dgvRecent);
            Label lblListTitle = new Label { Text = "HỢP ĐỒNG MỚI", Font = new Font("Segoe UI", 11, FontStyle.Bold), Dock = DockStyle.Top, Height = 30, ForeColor = Color.DimGray };
            pnlListContainer.Controls.Add(dgvRecent);
            pnlListContainer.Controls.Add(lblListTitle);

            // Wrapper
            Panel pnlListWrapper = new Panel { Dock = DockStyle.Fill, Padding = new Padding(10, 0, 0, 0) }; // Hở bên trái 10px
            pnlListWrapper.Controls.Add(pnlListContainer);
            tlpBody.Controls.Add(pnlListWrapper, 1, 0);

            tlpMain.Controls.Add(tlpBody, 0, 2);
        }

        // --- HÀM TẠO THẺ CARD RESPONSIVE ---
        private Panel CreateResponsiveCard(string title, string value, string icon, Color bgColor, ref Label lblOutput)
        {
            // Panel bao ngoài để tạo margin (khoảng cách giữa các thẻ)
            Panel container = new Panel { Dock = DockStyle.Fill, Padding = new Padding(5) };

            // Panel nội dung chính (Màu nền)
            Panel pnlContent = new Panel { Dock = DockStyle.Fill, BackColor = bgColor };

            Label lblIcon = new Label
            {
                Text = icon,
                Font = new Font("Segoe UI", 45),
                ForeColor = Color.FromArgb(60, 255, 255, 255), // Mờ
                AutoSize = true,
                BackColor = Color.Transparent,
                Anchor = AnchorStyles.Top | AnchorStyles.Right // Neo góc phải
            };
            lblIcon.Location = new Point(pnlContent.Width - 100, 10); // Vị trí tương đối

            Label lblTitle = new Label
            {
                Text = title,
                ForeColor = Color.WhiteSmoke,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(15, 20)
            };

            lblOutput.Text = value;
            lblOutput.ForeColor = Color.White;
            lblOutput.Font = new Font("Segoe UI", 24, FontStyle.Bold);
            lblOutput.AutoSize = true;
            lblOutput.Location = new Point(10, 55);

            pnlContent.Controls.Add(lblIcon);
            pnlContent.Controls.Add(lblTitle);
            pnlContent.Controls.Add(lblOutput);

            // Xử lý sự kiện Resize để Icon luôn nằm góc phải
            pnlContent.Resize += (s, e) => { lblIcon.Left = pnlContent.Width - lblIcon.Width - 10; };

            container.Controls.Add(pnlContent);
            return container;
        }

        // --- CÁC HÀM LOGIC (GIỮ NGUYÊN) ---
        private Chart CreateRevenueChart()
        {
            Chart chart = new Chart();
            ChartArea area = new ChartArea();
            area.AxisX.MajorGrid.LineColor = Color.LightGray;
            area.AxisY.MajorGrid.LineColor = Color.LightGray;
            area.AxisX.LabelStyle.Font = new Font("Segoe UI", 8);
            area.AxisY.LabelStyle.Font = new Font("Segoe UI", 8);
            chart.ChartAreas.Add(area);

            Series series = new Series
            {
                Name = "Doanh Thu",
                Color = Color.FromArgb(24, 161, 251),
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true
            };
            chart.Series.Add(series);
            series.Points.AddXY("T1", 50000000);
            series.Points.AddXY("T2", 75000000);
            series.Points.AddXY("T3", 45000000);
            series.Points.AddXY("T4", 90000000);
            series.Points.AddXY("T5", 120000000);
            return chart;
        }

        private void StyleRecentGrid(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = Color.White;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.RowHeadersVisible = false;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gray;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 30;
            dgv.DefaultCellStyle.SelectionBackColor = Color.WhiteSmoke;
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dgv.RowTemplate.Height = 40;
            dgv.GridColor = Color.WhiteSmoke;
            dgv.AllowUserToAddRows = false;
            dgv.ReadOnly = true;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadRealData()
        {
            try
            {
                DataTable dt1 = DatabaseHelper.GetData("SELECT COUNT(*) FROM Buildings");
                if (dt1.Rows.Count > 0) lblBuildingCount.Text = dt1.Rows[0][0].ToString();

                DataTable dt2 = DatabaseHelper.GetData("SELECT COUNT(*) FROM Customers");
                if (dt2.Rows.Count > 0) lblCustomerCount.Text = dt2.Rows[0][0].ToString();

                DataTable dt3 = DatabaseHelper.GetData("SELECT SUM(Value) FROM Contracts");
                if (dt3.Rows.Count > 0 && dt3.Rows[0][0] != DBNull.Value)
                    lblRevenue.Text = Convert.ToDecimal(dt3.Rows[0][0]).ToString("N0");
                else
                    lblRevenue.Text = "0";

                DataTable dt4 = DatabaseHelper.GetData("SELECT COUNT(*) FROM Contracts");
                if (dt4.Rows.Count > 0) lblContractCount.Text = dt4.Rows[0][0].ToString();
            }
            catch { lblBuildingCount.Text = "-"; }
        }

        private void LoadRecentContracts(DataGridView dgv)
        {
            try
            {
                string query = "SELECT TOP 5 CustomerName AS [Khách], ContractCode AS [Mã HĐ], Status AS [Trạng Thái] FROM Contracts ORDER BY Id DESC";
                DataTable dt = DatabaseHelper.GetData(query);
                dgv.DataSource = dt;
            }
            catch { }
        }
    }
}