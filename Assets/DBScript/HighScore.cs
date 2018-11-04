using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class HighScore : IComparable<HighScore>
{
    public int Score { get; set; }
    public string Name { get; set; }
    public DateTime Date { get; set; }
    public int ID { get; set; }
    public int Diamond { get; set; }

    public HighScore(int id, int score, string name, int diamond , DateTime date)
    {
        this.Score = score;
        this.Name = name;
        this.ID = id;
        this.Diamond = diamond;
        this.Date = date;
    }

    public int CompareTo(HighScore other)
    {

        if (other.Diamond < this.Diamond)
        {
            return -1;
        }

        else if (other.Diamond > this.Diamond)
        {
            return 1;

        }

        
        else if (other.Date<this.Date)
        {
            return -1;
        }

        else if (other.Date > this.Date)
        {
            return 1;
        }

        return 0;
    }

}

