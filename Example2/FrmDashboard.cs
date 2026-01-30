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
        private Label lblStudentCount = new Label();
        private Label lblRevenue = new Label();
        private Label lblOccupancyRate = new Label();

        public FrmDashboard()
        {
            InitializeComponent();
            DesignResponsiveDashboard();
            LoadRealData();
        }

        // --- 1. LOGIC TẢI DỮ LIỆU ---
        private void LoadRealData()
        {
            // 1. Tổng Tòa Nhà
            try
            {
                DataTable dt = DatabaseHelper.GetData("SELECT COUNT(*) FROM Buildings");
                if (dt.Rows.Count > 0) lblBuildingCount.Text = dt.Rows[0][0].ToString();
            }
            catch { lblBuildingCount.Text = "0"; }

            // 2. Tổng Sinh Viên
            try
            {
                string query = "SELECT COUNT(DISTINCT CustomerId) FROM Contracts WHERE Status = N'Hiệu lực'";
                DataTable dt = DatabaseHelper.GetData(query);
                if (dt.Rows.Count > 0) lblStudentCount.Text = dt.Rows[0][0].ToString();
            }
            catch { lblStudentCount.Text = "0"; }

            // 3. Tổng Doanh Thu
            try
            {
                string query = "SELECT SUM(Price) FROM Contracts WHERE Status = N'Hiệu lực'";
                DataTable dt = DatabaseHelper.GetData(query);

                if (dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
                {
                    decimal rev = Convert.ToDecimal(dt.Rows[0][0]);
                    lblRevenue.Text = rev.ToString("N0");
                }
                else
                {
                    lblRevenue.Text = "0";
                }
            }
            catch { lblRevenue.Text = "0"; }

            // 4. Tỷ lệ Lấp Đầy
            try
            {
                string qTotal = "SELECT COUNT(*) FROM Rooms";
                string qRented = "SELECT COUNT(*) FROM Rooms WHERE Status = N'Đã thuê'";

                int total = Convert.ToInt32(DatabaseHelper.GetData(qTotal).Rows[0][0]);
                int rented = Convert.ToInt32(DatabaseHelper.GetData(qRented).Rows[0][0]);

                if (total > 0)
                {
                    double rate = (double)rented / total * 100;
                    lblOccupancyRate.Text = $"{rate:0.0}%";
                }
                else
                {
                    lblOccupancyRate.Text = "0%";
                }
            }
            catch { lblOccupancyRate.Text = "0%"; }
        }

        private void LoadRecentContracts(DataGridView dgv)
        {
            try
            {
                string query = @"SELECT TOP 5 
                                    c.Name AS [Sinh Viên], 
                                    b.Name + ' - ' + r.Name AS [Phòng], 
                                    ct.Status AS [Trạng Thái] 
                                 FROM Contracts ct
                                 JOIN Customers c ON ct.CustomerId = c.Id
                                 JOIN Rooms r ON ct.RoomId = r.Id
                                 JOIN Buildings b ON r.BuildingId = b.Id
                                 ORDER BY ct.Id DESC";

                DataTable dt = DatabaseHelper.GetData(query);
                dgv.DataSource = dt;
            }
            catch { }
        }

        // --- 2. GIAO DIỆN ---
        private void DesignResponsiveDashboard()
        {
            this.BackColor = Color.FromArgb(245, 247, 250);
            this.Padding = new Padding(20);

            // Layout Chính
            TableLayoutPanel tlpMain = new TableLayoutPanel();
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.ColumnCount = 1;
            tlpMain.RowCount = 3;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 180F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.Controls.Add(tlpMain);

            // A. Header
            Panel pnlHeader = new Panel { Dock = DockStyle.Fill };
            Label lblTitle = new Label
            {
                Text = "TỔNG QUAN KÝ TÚC XÁ",
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

            // B. Cards
            TableLayoutPanel tlpCards = new TableLayoutPanel();
            tlpCards.Dock = DockStyle.Fill;
            tlpCards.ColumnCount = 4;
            tlpCards.RowCount = 1;
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));

            tlpCards.Controls.Add(CreateResponsiveCard("TÒA KTX", "0", "🏢", Color.FromArgb(108, 92, 231), ref lblBuildingCount), 0, 0);
            tlpCards.Controls.Add(CreateResponsiveCard("SINH VIÊN", "0", "👥", Color.FromArgb(253, 121, 168), ref lblStudentCount), 1, 0);
            tlpCards.Controls.Add(CreateResponsiveCard("DOANH THU/THÁNG", "0", "💰", Color.FromArgb(0, 184, 148), ref lblRevenue), 2, 0);
            tlpCards.Controls.Add(CreateResponsiveCard("TỶ LỆ LẤP ĐẦY", "0", "📊", Color.FromArgb(225, 112, 85), ref lblOccupancyRate), 3, 0);

            tlpMain.Controls.Add(tlpCards, 0, 1);

            // C. Body
            TableLayoutPanel tlpBody = new TableLayoutPanel();
            tlpBody.Dock = DockStyle.Fill;
            tlpBody.ColumnCount = 2;
            tlpBody.RowCount = 1;
            tlpBody.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tlpBody.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tlpBody.Padding = new Padding(0, 20, 0, 0);

            // C.1 Biểu đồ
            Panel pnlChartContainer = new Panel { Dock = DockStyle.Fill, BackColor = Color.White, Padding = new Padding(10) };
            Chart roomStatusChart = CreateRoomStatusChart();
            roomStatusChart.Dock = DockStyle.Fill;
            Label lblChartTitle = new Label { Text = "THỐNG KÊ TRẠNG THÁI PHÒNG", Font = new Font("Segoe UI", 11, FontStyle.Bold), Dock = DockStyle.Top, Height = 30, ForeColor = Color.DimGray };
            pnlChartContainer.Controls.Add(roomStatusChart);
            pnlChartContainer.Controls.Add(lblChartTitle);

            Panel pnlChartWrapper = new Panel { Dock = DockStyle.Fill, Padding = new Padding(0, 0, 10, 0) };
            pnlChartWrapper.Controls.Add(pnlChartContainer);
            tlpBody.Controls.Add(pnlChartWrapper, 0, 0);

            // C.2 Danh sách
            Panel pnlListContainer = new Panel { Dock = DockStyle.Fill, BackColor = Color.White, Padding = new Padding(10) };
            DataGridView dgvRecent = new DataGridView();
            StyleRecentGrid(dgvRecent);
            dgvRecent.Dock = DockStyle.Fill;
            LoadRecentContracts(dgvRecent);
            Label lblListTitle = new Label { Text = "SINH VIÊN MỚI THUÊ", Font = new Font("Segoe UI", 11, FontStyle.Bold), Dock = DockStyle.Top, Height = 30, ForeColor = Color.DimGray };
            pnlListContainer.Controls.Add(dgvRecent);
            pnlListContainer.Controls.Add(lblListTitle);

            Panel pnlListWrapper = new Panel { Dock = DockStyle.Fill, Padding = new Padding(10, 0, 0, 0) };
            pnlListWrapper.Controls.Add(pnlListContainer);
            tlpBody.Controls.Add(pnlListWrapper, 1, 0);

            tlpMain.Controls.Add(tlpBody, 0, 2);
        }

        private Panel CreateResponsiveCard(string title, string value, string icon, Color bgColor, ref Label lblOutput)
        {
            Panel container = new Panel { Dock = DockStyle.Fill, Padding = new Padding(5) };
            Panel pnlContent = new Panel { Dock = DockStyle.Fill, BackColor = bgColor };

            Label lblIcon = new Label
            {
                Text = icon,
                Font = new Font("Segoe UI", 45),
                ForeColor = Color.FromArgb(60, 255, 255, 255),
                AutoSize = true,
                BackColor = Color.Transparent,
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };
            lblIcon.Location = new Point(pnlContent.Width - 100, 10);

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
            pnlContent.Resize += (s, e) => { lblIcon.Left = pnlContent.Width - lblIcon.Width - 10; };

            container.Controls.Add(pnlContent);
            return container;
        }

        // --- CẬP NHẬT BIỂU ĐỒ: THÊM CHÚ THÍCH (LEGEND) ---
        private Chart CreateRoomStatusChart()
        {
            Chart chart = new Chart();

            // 1. Tạo Legend (Chú thích)
            Legend legend = new Legend("MainLegend");
            legend.Docking = Docking.Bottom; // Đặt chú thích ở dưới cùng
            legend.Alignment = StringAlignment.Center; // Canh giữa
            legend.Font = new Font("Segoe UI", 10); // Chỉnh font chữ cho đẹp
            chart.Legends.Add(legend);

            ChartArea area = new ChartArea();
            chart.ChartAreas.Add(area);

            Series series = new Series
            {
                Name = "Status",
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true,
                Legend = "MainLegend" // Liên kết Series với Legend vừa tạo
            };
            chart.Series.Add(series);

            // Lấy dữ liệu thật từ DB
            try
            {
                DataTable dtEmpty = DatabaseHelper.GetData("SELECT COUNT(*) FROM Rooms WHERE Status = N'Còn trống'");
                DataTable dtRented = DatabaseHelper.GetData("SELECT COUNT(*) FROM Rooms WHERE Status = N'Đã thuê'");

                int empty = Convert.ToInt32(dtEmpty.Rows[0][0]);
                int rented = Convert.ToInt32(dtRented.Rows[0][0]);

                if (empty > 0 || rented > 0)
                {
                    series.Points.AddXY("Còn trống", empty);
                    series.Points.AddXY("Đã thuê", rented);

                    series.Points[0].Color = Color.FromArgb(0, 184, 148); // Xanh lá
                    series.Points[1].Color = Color.FromArgb(220, 53, 69); // Đỏ

                    // Cập nhật text cho chú thích
                    series.Points[0].LegendText = "Còn trống";
                    series.Points[1].LegendText = "Đã thuê";
                }
                else
                {
                    series.Points.AddXY("Chưa có dữ liệu", 1);
                }
            }
            catch { }

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
    }
}