@echo Abstraction: %1 Adding to Demo: %2

call git submodule add git://github.com/abstractiondev/%1 %2/Abstractions/%1
call git submodule update --init
