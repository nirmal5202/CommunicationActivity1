using System;
using System.Collections.Generic;
using System.Text;

namespace CommunicationActivity1
{
    public class Program
    {
        private string name;
        private double sid;
        private int projectStatus;

        public Program(string name, double sid, int projectStatus)
        {
            this.name = name;
            this.sid = sid;
            this.projectStatus = projectStatus;
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public double Sid
        {
            get { return this.sid; }
            set { this.sid = value; }
        }
        public int ProjectStatus
        {
            get { return this.projectStatus; }
            set { this.projectStatus = value; }
        }
    }
}
