#!/bin/bash

UP=$(pgrep mysql | wc -l);
if [ "$UP" -eq 0 ];
then
    echo "'''''''''''''''''''''''''"
    echo "MySQL is down.";
    echo "Starting my sql"
    service mysql start

else
    echo "'''''''''''''''''''''''''"
    echo "MySql is up.";
fi
echo "'''''''''''''''''''''''''"
echo "Running dotnet build"
dotnet build
echo "'''''''''''''''''''''''''"
echo "Running dotnet project"
dotnet run