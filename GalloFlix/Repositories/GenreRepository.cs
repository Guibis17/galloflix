namespace GalloFlix.Repositories;

using System.Collections.Generic;
using GalloFlix.interfaces;
using GalloFlix.Models;

public class GenreRepository : IGenreRepository
{
    string connectionString = "server=localhost;port=3306;database=galloflixdb;uid=root;pwd=''";
    public void create(Genre model)
    {
        throw new NotImplementedException();
    }

    public void Delete(int? id)
    {
        throw new NotImplementedException();
    }

    public List<Genre> readAll()
    {
        throw new NotImplementedException();
    }

    public Genre readyById(int? id)
    {
        throw new NotImplementedException();
    }

    public void update(Genre model)
    {
        throw new NotImplementedException();
    }
}