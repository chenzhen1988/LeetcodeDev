#!/bin/bash

echo "start report lcov coverage"
./tools/coverage/lcov -d build -b . --no-external -c -o ./build/CMakeGcovSupportCoverage.info
./tools/coverage/genhtml -o ./build/CMakeGcovSupportCoverageReport --prefix=`pwd` ./build/CMakeGcovSupportInitialCoverage.info ./build/CMakeGcovSupportCoverage.info

exit 1
