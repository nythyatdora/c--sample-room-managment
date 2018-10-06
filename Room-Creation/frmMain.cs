using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Room_Creation
{
    /**
     *  
     *  Author : Dora
     *  
     *  Note : You can make any changes you want, but don't remove these.
     *          - private use only
     */

    public partial class frmMain : Form
    {
        struct Room
        {
            String room_number;
            String room_type;
            String room_price;
            String room_photo_location;

            Room(String room_number, String room_type, String room_price, String room_photo_location)
            {
                this.room_number = room_number;
                this.room_type = room_type;
                this.room_price = room_price;
                this.room_photo_location = room_photo_location;
            }

            public String RoomNumber
            {
                set { this.room_number = value; }
                get { return this.room_number; }
            }

            public String RoomType
            {
                set { this.room_type = value; }
                get { return this.room_type; }
            }

            public String RoomPrice
            {
                set { this.room_price = value; }
                get { return this.room_price; }
            }

            public String RoomPhotoLocation
            {
                set { this.room_photo_location = value; }
                get { return this.room_photo_location; }
            }
        }

        private Room[] rooms;
        // private String room_description;
        public frmMain()
        {
            InitializeComponent();
            filedialog_profile.Filter = "ImageFile|*.png; *jpg;";
            picbox_room_picture.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            filedialog_profile.ShowDialog();
            picbox_room_picture.ImageLocation = filedialog_profile.FileName;
        }

        private void lbl_student_id_Click(object sender, EventArgs e)
        {
            txt_room_number.Focus();
        }

        private void lbl_student_name_Click(object sender, EventArgs e)
        {
            txt_room_type.Focus();
        }

        private void lbl_address_Click(object sender, EventArgs e)
        {
            txt_room_price.Focus();
        }

        private void lbl_photo_Click(object sender, EventArgs e)
        {
            btn_browse.Focus();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            // room_description = txt_room_number.Text + "\t" + txt_room_type.Text + "\t"
            //                    + txt_room_price.Text;

            //  MessageBox.Show(room_description);

            Room temp_room = new Room();
            temp_room.RoomNumber = txt_room_number.Text;
            temp_room.RoomType = txt_room_type.Text;
            temp_room.RoomPrice = txt_room_price.Text;
            temp_room.RoomPhotoLocation = picbox_room_picture.ImageLocation;

            int new_n;
            /**
             *  instead try-catch we can also use if-else
             * 
             *  if( rooms != null ) {
             *      new_n = rooms.Length + 1;
             *  }
             *  else {
             *      new_n = 1;
             *  }
             */

            try
            {
                new_n = rooms.Length + 1;
            }
            catch(NullReferenceException)
            {
                new_n = 1;
            }

            // create a new rooms array which its element increased by 1
            Room[] new_rooms = new Room[new_n];

            // insertion
            // assign rooms array to the new rooms array 
            if(rooms != null)
                rooms.CopyTo(new_rooms, 0);

            new_rooms[new_rooms.Length-1] = temp_room;
            rooms = new_rooms;

            clearViews();
        }

        private void clearViews()
        {
            txt_room_number.Text = "";
            txt_room_type.Text = "";
            txt_room_price.Text = "";
            picbox_room_picture.ImageLocation = "";

            txt_room_number.Focus();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (rooms != null)
            {
                for (int i = 0; i < rooms.Length; i++)
                {
                    if (rooms[i].RoomNumber == txt_room_number.Text)
                    {
                        MessageBox.Show("Found!");
                        txt_room_number.Text = rooms[i].RoomNumber;
                        txt_room_type.Text = rooms[i].RoomType;
                        txt_room_price.Text = rooms[i].RoomPrice;
                        picbox_room_picture.ImageLocation = rooms[i].RoomPhotoLocation;
                    }
                }
            }
            else
            {
                MessageBox.Show("Empty!");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (rooms != null) {

                // makes a copy of original rooms array
                Room[] temp_rooms;
                temp_rooms = rooms;

                for (int i = 0; i < rooms.Length; i++)
                {
                    // check if the input room in textfield matches with rooms array
                    if (temp_rooms[i].RoomNumber == txt_room_number.Text) // Found
                    {
                        MessageBox.Show("Deleted!");

                        // deletion
                        // make a new rooms array which element decreased by 1 
                        int new_n = rooms.Length - 1;
                        Room[] new_rooms = new Room[new_n];

                        // overwrite over the element which to be delete
                        for(int j=i; j<rooms.Length - 1; j++)
                        {
                            temp_rooms[j] = temp_rooms[j+1];
                        }

                        // copy to a new rooms array
                        for(int k=0; k<new_n; k++)
                        {
                            new_rooms[k] = temp_rooms[k];
                        }

                        // assignt to the original array
                        rooms = new_rooms;
                        break;
                    }
                }
                clearViews();
            }
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            showRooms();
        }

        private void showRooms()
        {
            if (rooms != null)
            {
                String temp = "";
                for (int i = 0; i < rooms.Length; i++)
                {
                    temp = temp + rooms[i].RoomNumber + "\t"
                                + rooms[i].RoomType + "\t"
                                + rooms[i].RoomPrice + "\t"
                                + rooms[i].RoomPhotoLocation + "\n";

                }
                MessageBox.Show("Length of Rooms : " + rooms.Length);
                MessageBox.Show(temp);
            }
            else
            {
                // rooms = null which means no room -> 0 room
                MessageBox.Show("Length of Room(s) : 0");
            }
        }
    }
}
