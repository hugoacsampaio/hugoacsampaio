// Question: Fix the bug in this code and explain what was wrong.
// The method should return the top 3 highest-scoring students.

using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public string Name { get; set; }
    public int Score { get; set; }
}

public class Program
{
    public static List<Student> GetTopStudents(List<Student> students)
    {
        return students.Where(s => s.Score > 80)
                      .OrderBy(s => s.Score)
                      .Take(3)
                      .ToList();
    }
}