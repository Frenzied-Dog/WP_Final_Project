using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project {
    public partial class NotificationForm : Form {
        List<NotifyChunk> lists = new List<NotifyChunk>();
        string UID;
        public int count = 0;
        public MainMenuForm parent;

        public NotificationForm(MainMenuForm parent, MainDataSet db, string UID) {
            InitializeComponent();
            this.parent = parent;
            this.db = db;
            this.UID = UID;

            //AddNotify(NotifyType.NEW_EVENT, db.Activities.FindByID(1996046805));
            //AddNotify(NotifyType.EVENT_SOON, db.Activities.FindByID(1996046805));
        }

        public void Check() {
            foreach (var ua in db.User_Activity.Select($"UserID = '{UID}'")) {
                var act = db.Activities.FindByID(ua.Field<int>("ActivityID"));
                
                if (act.EstimateTime < DateTime.Now) continue;

                // check deleted events
                if (act.Deleted && !lists.Exists(x => x.type == NotifyType.EVENT_CANCELED && x.actID == act.ID)) {
                    AddNotify(NotifyType.EVENT_CANCELED, act);
                }
            
                // check event soon
                var timeLeft = act.EstimateTime.Subtract(DateTime.Now).TotalMinutes;
                if (!act.Deleted && timeLeft > 0 && timeLeft < 15 && !lists.Exists(x => x.type == NotifyType.EVENT_SOON && x.actID == act.ID)) {
                    AddNotify(NotifyType.EVENT_SOON, act);
                }
            }

            var me = db.Users.FindByID(UID);
            // check new events
            foreach (var act in db.Activities.Select($"Deleted = false AND EstimateTime > '{DateTime.Now:g}' AND" +
                                                                     $" PreferTime = {me.PreferTime} AND Budget = {me.Budget} AND MainUserId <> '{UID}'")) {
                int actID = act.Field<int>("ID");
                if (!db.User_Activity.Select($"UserID = '{UID}' AND ActivityID = {actID}").Any() &&
                        !lists.Exists(x => x.type == NotifyType.NEW_EVENT && x.actID == actID)) {
                    AddNotify(NotifyType.NEW_EVENT, db.Activities.FindByID(actID));
                }
            }
        }

        public void RemoveNotify(NotifyChunk toRemove) {
            MainPanel.Controls.Remove(toRemove);
            lists.Remove(toRemove);
            count--;
            int i = 0;
            foreach (var item in lists) {
                item.Location = new Point(110, 90 + 220 * i++);
            }
        }

        void AddNotify(NotifyType type, MainDataSet.ActivitiesRow act) {
            var tmp = new NotifyChunk(this, db, UID, type, act);
            MainPanel.Controls.Add(tmp);
            tmp.Location = new Point(110, 90 + 220 * count);
            lists.Add(tmp);
            count++;
        }
    }
}
