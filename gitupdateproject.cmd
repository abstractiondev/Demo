@echo Pull for root project...
call git pull
@echo Pull for submodules...
call git submodule foreach git pull origin master