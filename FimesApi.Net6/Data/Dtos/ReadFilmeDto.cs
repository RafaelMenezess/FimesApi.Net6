﻿namespace FimesApi.Net6.Data.Dtos;

public class ReadFilmeDto
{

    public string Titulo { get; set; }
    public string Genero { get; set; }
    public int Duracao { get; set; }
    public DateTime HoraConsulta { get; set;} = DateTime.Now;
}