using UPB.CoreLogic.Models;
using System;

namespace UPB.CoreLogic.Managers;

public class PatientManager
{
    private string _path;
    
    public PatientManager(string path)
    {
        _path = path;
    }

    public List<Patients> GetAll()
    {

    }

    public Patients GetByCI(int ci)
    {

    }

    public Patients Update(int ci, string name, string lastname)
    {
 
    }
    public Patients Create(string name, string lastname, int age, int ci)
    {

    }

    public Patients Delete(int ci)
    {

    }

}