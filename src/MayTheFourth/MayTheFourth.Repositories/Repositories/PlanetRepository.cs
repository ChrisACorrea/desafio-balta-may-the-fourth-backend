﻿using MayTheFourth.Entities;
using MayTheFourth.Repositories.Context;
using MayTheFourth.Repositories.Repositories.Interfaces;

namespace MayTheFourth.Repositories.Repositories;

public class PlanetRepository(DatabaseContext context) :
    BaseRepository<Planet>(context),
    IPlanetRepository
{
}
