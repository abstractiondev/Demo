@echo Abstraction: %1 Adding to Demo: %2

git submodule add git@github.com:abstractiondev/%1 %2/Abstractions/%1
@echo Enter afterwards: git submodule update --init
