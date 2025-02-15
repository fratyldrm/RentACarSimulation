﻿using RentACar.ConsoleUI.Model;
using RentACar.ConsoleUI.Model.Dto;

namespace RentACar.ConsoleUI.Interface;

public interface ICarService
{
    void Add(Car car);
    void Update(int id, int kiloMeter, double dailyPrice);
    void Delete(int id);
    Car GetById(int id);
    List<Car> GetAll();
    CarDetailDto GetCarDetailById(int id);
    List<CarDetailDto> GetAllCarDetails();
    List<CarDetailDto> GetAllDetailsByFuelName(string name);
}