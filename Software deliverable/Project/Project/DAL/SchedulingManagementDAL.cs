using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.LGC;

namespace Project.DAL
{
    class SchedulingManagementDAL : BaseDAL
    {
        private List<Availability> availabilities;
        private List<Schedule> schedules;

        public SchedulingManagementDAL()
        {
            base.CreateConnection();
            availabilities = new List<Availability>();
            schedules = new List<Schedule>();
        }

        public List<Schedule> GetListOfAllSchedulesFromDataBase()
        {
            return schedules;
        }

        public List<Availability> GetListOfAllAvailabilitiesFromDatabase()
        {
            return availabilities;
        }

        public void AddToDtbListOfAvailability()
        {
            try
            {
                conn.Open();
                //sql code for selecting all th data from the table 
                string sql = "SELECT UserID, Date, Shift FROM availability";
                cmd = new MySqlCommand(sql, conn);
                dr = cmd.ExecuteReader();

                //this is to loop through the results 
                while (dr.Read())
                {
                    //here we are changing all results into objects employee
                    Availability availability = new Availability(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString());

                    //once changed into object department we add into a list
                    availabilities.Add(availability);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Close(); }
        }

        public bool AddSchedule(int UserID, string Date, string TimeShift)
        {
            try
            {
                conn.Open();
                string sql = "INSERT INTO schedules (UserID, WorkDate, TimeShift) VALUES (@UserID, @WorkDate, @TimeShift)";
                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@UserID", UserID);
                cmd.Parameters.AddWithValue("@WorkDate", Date);
                cmd.Parameters.AddWithValue("@TimeShift", TimeShift);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public void RemoveSchedule(int UserID, string Date, string shift)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand($"DELETE FROM schedules WHERE UserID= @UserID AND WorkDate= @Date AND TimeShift= @Shift", conn);
                cmd.Parameters.AddWithValue("@ScheduleID", UserID);
                cmd.Parameters.AddWithValue("@WorkDate", Date);
                cmd.Parameters.AddWithValue("@TimeShift", shift);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Close(); }
        }

        public void AddToDtbListOfSchedules()
        {
            try
            {
                conn.Open();
                //sql code for selecting all th data from the table 
                string sql = "SELECT UserID, WorkDate, TimeShift FROM schedule";
                cmd = new MySqlCommand(sql, conn);
                dr = cmd.ExecuteReader();

                //this is to loop through the results 
                while (dr.Read())
                {
                    //here we are changing all results into objects employee
                    Schedule schedule = new Schedule(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString());

                    //once changed into object department we add into a list
                    schedules.Add(schedule);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Close(); }
        }
    }
}
