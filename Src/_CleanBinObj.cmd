@echo off
@REM //------------------------------------------------------------------------------
@REM 03/08/2009
@REM //------------------------------------------------------------------------------
@REM Nettoyage des repertoires bin et obj de la solution  
@REM //------------------------------------------------------------------------------


rd /S /Q MasterClasses\bin
rd /S /Q MasterClasses\obj

rd /S /Q MasterClassesTests\bin
rd /S /Q MasterClassesTests\obj

rd /S /Q TestResults

echo on
