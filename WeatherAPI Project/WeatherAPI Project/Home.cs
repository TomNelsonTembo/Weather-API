using Newtonsoft.Json;
using System.Net;
using System.Windows.Forms;
using System.Data;
using System.Data.SQLite;



namespace WeatherAPI_Project
{
    public partial class Home : Form
    {
        //initializes datatable and database
        DataTable hstry = new DataTable();
        Database db_object = new Database();

        //method to extract and display history from Database
        void Show_history()
        {
            

            db_object.Openconnection();
            SQLiteDataReader dr;

            

            string insert = "SELECT Date, City, Temp, W_Speed, Pressure, S_Rise, S_Set FROM History ORDER BY Date DESC";
            var cmd = new SQLiteCommand(insert, db_object.connection);
            dr = cmd.ExecuteReader();

            
            if (dr.HasRows)
            {
                
                while (dr.Read())
                {
                    DataRow row = hstry.NewRow();
                    row[0] = dr.GetString(0);
                    row[1] = dr.GetString(1);
                    row[2] = dr.GetString(2);
                    row[3] = dr.GetString(3);
                    row[4] = dr.GetString(4);
                    row[5] = dr.GetString(5);
                    row[6] = dr.GetString(6);

                    hstry.Rows.Add(row);
                    hstry_dgv.DataSource = hstry;

                }
               
                
            }
        }
        public Home()
        {
            //Initilizes  columns in Datatable
            hstry.Columns.Add("DATE");
            hstry.Columns.Add("CITY");
            hstry.Columns.Add("TEMP");
            hstry.Columns.Add("WINDSPEED");
            hstry.Columns.Add("PRESSURE");
            hstry.Columns.Add("SUNRISE");
            hstry.Columns.Add("SUNSET");

            InitializeComponent();
            Show_history(); //Displays history at start of program

            
        }

        string Key = "40e16a01c56e25b0097eb4d508e24cbb"; //https://api.openweathermap.org Private API KEY
        private void btn_search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TBcity.Text))
            {
                MessageBox.Show("Please Enter City/Country") ;
            }
            else
            {
                getWeather();
                TBcity.Clear();
                hstry.Clear();
                Show_history();
                
            }
            
        }
        //Method that coverts Fahrenheit to Celsius
        public int convert(int val)
        {
            return val - 273;       

        }

        //Method saves data to the database
        void Save_data()
        {
            string today = DateTime.Now.ToString("h:mm:ss dd-MM-yyyy");
            db_object.Openconnection();

            string query = "INSERT INTO History ('Date', 'City', 'Temp', 'W_Speed', 'Pressure', 'S_Rise', 'S_Set') VALUES (?, ?, ?, ?, ?, ?, ?)";
            using(SQLiteCommand cmd = new SQLiteCommand(query, db_object.connection))
            {
                cmd.Parameters.AddWithValue("Date", today);
                cmd.Parameters.AddWithValue("City", city_name.Text);
                cmd.Parameters.AddWithValue("Temp", temp_lbl.Text);
                cmd.Parameters.AddWithValue("W_Speed", windspeed_details.Text);
                cmd.Parameters.AddWithValue("Pressure", pressure_details.Text);
                cmd.Parameters.AddWithValue("S_Rise", sunset_details.Text);
                cmd.Parameters.AddWithValue("S_Set", sunset_details.Text);
                try
                {
                    var execute = cmd.ExecuteNonQuery();
                    if (execute != 0)
                    {
                        //Do Nothing
                    }
                    else
                    {
                        MessageBox.Show("Unsuccesfull Please Try Again!");
                    }
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            db_object.Closeconnection();

            



                
            
        }



        //Method that gets Weather from https://api.openweathermap.org with provided API Key
        void getWeather()
        {
            using(WebClient web = new WebClient())
            {
                
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", TBcity.Text, Key);
                try
                {
                    
                    var json = web.DownloadString(url);
                    WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);
                    
                    weather_ico.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                    labelcondition.Text = Info.weather[0].main;
                    labelDetails.Text = Info.weather[0].description;

                    sunset_details.Text = convert_datetime(Info.sys.sunset).ToShortTimeString();
                    Sunrise_details.Text = convert_datetime(Info.sys.sunrise).ToShortTimeString();

                    windspeed_details.Text = Info.wind.speed.ToString() + " m/s";
                    pressure_details.Text = Info.main.pressure.ToString() + " hPa";

                    temp_lbl.Text = convert(((int)Info.main.temp)) + "°C";

                    city_name.Text = TBcity.Text.ToUpper();
                    Save_data();

                    //Trys to change color of Temperature Depending on weather
                    try
                    {
                        int temp = convert(((int)Info.main.temp));
                        if (temp > 20)
                        {
                            temp_lbl.ForeColor = Color.Red;

                        }
                        else
                        {
                            temp_lbl.ForeColor = Color.Blue;
                        }
                    }catch (Exception ex) // cathes any Exception that might occur
                    {
                        MessageBox.Show(ex.Message);
                    }



                }
                catch(WebException ex)//
                {
                    MessageBox.Show("ERROR! CITY/COUNTRY NOT FOUND! \n" + ex.Message);
                    

                }                 
                         
            }

            DateTime convert_datetime(long inital)
            {
                DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
                day = day.AddSeconds(inital).ToLocalTime();

                return day;
            }
        }

        private void TBcity_TextChanged(object sender, EventArgs e)
        {           
            
        }

        private void Home_Load(object sender, EventArgs e)
        {
            
        }

        private void date_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void city_name_Click(object sender, EventArgs e)
        {
            
        }

        private void temp_lbl_MouseMove(object sender, MouseEventArgs e)
        {
            
            
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            db_object.Openconnection();
            string query = "DELETE FROM 'History'";
            using (SQLiteCommand cmd = new SQLiteCommand(query, db_object.connection))
            {
                var execute = cmd.ExecuteNonQuery();
                if(execute != 0)
                {
                    //
                }
                else
                {
                    MessageBox.Show("No Rows Found!");

                }

            }
            db_object.Closeconnection();
            hstry.Clear();
        }
    }
}