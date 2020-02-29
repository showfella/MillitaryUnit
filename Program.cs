using System;

namespace MillitaryUnit
{
    class Program
    {
        static void Main()
        {
            Personnel soldier = new Soldier(24, "Ahmed");
            soldier.TrainingSchool();

            Personnel naval = new Naval(29, "Gideon");
            naval.TrainingSchool();

            Weapon ak47 = new AK47();
            Weapon m24 = new M24();

            ak47.FiringRange();
            m24.FiringRange();

            ak47.RateOfFire();
            m24.RateOfFire();

            ak47.Weight();
            m24.Weight();
           
        }
    }
}




public abstract class Personnel
{
    public abstract void TrainingSchool();
    public abstract string RecruitmentAge { get; }
}

public abstract class Weapon
{
    public abstract void FiringRange();
    public abstract void RateOfFire();
    public abstract void Weight();


}


public class Soldier : Personnel
{
    protected int age;
    protected string name;

    public Soldier(int age, string name)
    {
        this.age = age;
        this.name = name;
        
    }
    public override string RecruitmentAge
    {
        get
        {
            try
            {
                if (age < 25)
                {
                    return age.ToString();
                }
                else
                {
                    return ("Recruitment age cannot be less than 25");
                }

            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
    }

    public override void TrainingSchool()
    {
        Console.WriteLine("{0} is {1} and Millitary School is located in new york", name, RecruitmentAge);
    }

}

public class Naval : Personnel
{
    protected int age;
    protected string name;

    public Naval(int age, string name)
    {
        this.age = age;
        this.name = name;

    }
    public override string RecruitmentAge
    {
        get
        {
            try
            {
                if (age < 30)
                {
                    return age.ToString();
                }
                else
                {
                    return ("Recruitment age cannot be less than 30");
                }

            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
    }

    public override void TrainingSchool()
    {
        Console.WriteLine("{0} is {1} and Naval School is located in Chicago", name, RecruitmentAge);
    }
}
public class M24 : Weapon
{
    public override void FiringRange()
    {
        Console.WriteLine("M24 has a firing Range of 800 - 1500 metres");
    }

    public override void RateOfFire()
    {
        Console.WriteLine("M24 has 20 revolution per minute");
    }
  

    public override void Weight()
    {
        Console.WriteLine("M24 weighs about 15 pounds");
    }
}

public class AK47 : Weapon
{
    public override void FiringRange()
    {
        Console.WriteLine("AK47 Effective firing range is 350m ");
    }

    public override void RateOfFire()
    {
        Console.WriteLine("AK47 has 20 revolution per minute");
    }

    public override void Weight()
    {
        Console.WriteLine("The weight of AK47 is  7.7 pounds");
    }
}
