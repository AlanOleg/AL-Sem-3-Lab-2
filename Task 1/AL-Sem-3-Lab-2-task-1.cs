using System;

public class Pupil
{
    public virtual void Study()
    {
        Console.WriteLine("Ученик учится.");
    }

    public virtual void Read()
    {
        Console.WriteLine("Ученик читает.");
    }

    public virtual void Write()
    {
        Console.WriteLine("Ученик пишет.");
    }

    public virtual void Relax()
    {
        Console.WriteLine("Ученик отдыхает.");
    }
}

public class ExcellentPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Отличник учится отлично.");
    }

    public override void Read()
    {
        Console.WriteLine("Отличник читает часто и внимательно.");
    }

    public override void Write()
    {
        Console.WriteLine("Отличник пишет без ошибок.");
    }

    public override void Relax()
    {
        Console.WriteLine("Отличник отдыхает.");
    }
}

public class GoodPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Хорошист учится хорошо.");
    }

    public override void Read()
    {
        Console.WriteLine("Хорошист читает внимательно.");
    }

    public override void Write()
    {
        Console.WriteLine("Хорошист пишет хорошо.");
    }

    public override void Relax()
    {
        Console.WriteLine("Хорошист отдыхает.");
    }
}

public class BadPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Ученик учится плохо.");
    }

    public override void Read()
    {
        Console.WriteLine("Ученик читает редко.");
    }

    public override void Write()
    {
        Console.WriteLine("Ученик делает много ошибок при написании.");
    }

    public override void Relax()
    {
        Console.WriteLine("Ученик отдыхает незаслуженно.");
    }
}

public class ClassRoom
{
    private Pupil[] pupils;

    public ClassRoom(params Pupil[] pupils)
    {
        if (pupils.Length < 2 || pupils.Length > 4)
        {
            throw new ArgumentException("Количество учеников должно быть от 2 до 4.");
        }

        this.pupils = pupils;
    }

    public void ShowPupilsSkills()
    {
        foreach (var pupil in pupils)
        {
            pupil.Study();
            pupil.Read();
            pupil.Write();
            pupil.Relax();
            Console.WriteLine(); // Разделитель между учениками
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Pupil pupil1 = new ExcellentPupil();
        Pupil pupil2 = new GoodPupil();
        Pupil pupil3 = new BadPupil();
        Pupil pupil4 = new BadPupil();

        ClassRoom classRoom = new ClassRoom(pupil1, pupil2, pupil3, pupil4);
        classRoom.ShowPupilsSkills();
    }
}
