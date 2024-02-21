﻿namespace Infrastructrue.Course;

public interface ICouresRepository
{
    void Create(Domain.Course.Course course);


    List<Domain.Course.Course> GetAll();


    Domain.Course.Course GetBy(int i);


    void Delete(int i);
}