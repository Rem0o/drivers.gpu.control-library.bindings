@echo off
IF NOT EXIST "..\drivers.gpu.control-library" (
    git clone https://github.com/intel/drivers.gpu.control-library.git "..\drivers.gpu.control-library"
) ELSE (
    git -C "..\drivers.gpu.control-library" fetch --all
    git -C "..\drivers.gpu.control-library" pull
)