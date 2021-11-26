using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treelvy
{
    public class common
    {
        public static treelvy.title title = null;
        public static treelvy.signin signin = null;
        public static treelvy.manager manager = null;
        public static treelvy.create create = null;
        public static treelvy.user_manager user_manager = null;
        public static treelvy.manager_user manager_user = null;
        public static treelvy.sift sift = null;
        public static treelvy.area area = null;
        public static treelvy.now now = null;
        public static treelvy.combo combo = null;
        public static treelvy.chart chart = null;

        public static title getTitleForm()
        {
            if (title == null)
            {
                title = new treelvy.title();
            }
            return title;
        }

        public static signin getSigninForm()
        {
            if (signin == null)
            {
                signin = new treelvy.signin();
            }
            return signin;
        }

        public static manager getManagerForm()
        {
            if (manager == null)
            {
                manager = new treelvy.manager();
            }
            return manager;
        }

        public static create getCreateForm()
        {
            if (create == null)
            {
                create = new treelvy.create();
            }
            return create;
        }

        public static user_manager getUser_managerForm()
        {
            if (user_manager == null)
            {
                user_manager = new treelvy.user_manager();
            }
            return user_manager;
        }

        public static manager_user getManager_userForm()
        {
            if (manager_user == null)
            {
                manager_user = new treelvy.manager_user();
            }
            return manager_user;
        }

        public static sift getSiftForm()
        {
            if (sift == null)
            {
                sift = new treelvy.sift();
            }
            return sift;
        }

        public static area getAreaForm()
        {
            if (area == null)
            {
                area = new treelvy.area();
            }
            return area;
        }

        public static now getNowForm()
        {
            if (now == null)
            {
                now = new treelvy.now();
            }
            return now;
        }

        public static combo getComboForm()
        {
            if (combo == null)
            {
                combo = new treelvy.combo();
            }
            return combo;
        }

        public static chart getChartForm()
        {
            if (chart == null)
            {
                chart = new treelvy.chart();
            }
            return chart;
        }
    }
}
