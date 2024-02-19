@echo off

set naturalDocsPath=C:\Program Files (x86)\Natural Docs
set naturalDocsConfig=%~dp0
echo naturalDocsPath: %naturalDocsPath%
echo naturalDocsConfig: %naturalDocsConfig%
cd %naturalDocsPath%
NaturalDocs.exe %naturalDocsConfig%

pause