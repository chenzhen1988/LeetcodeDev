#!/bin/bash

echo "start report lcov coverage"
lcov -d build_scons -b . --no-external -c -o ./build/CMakeGcovSupportCoverage.info
genhtml -o ./build/CMakeGcovSupportCoverageReport --prefix=`pwd` ./build/CMakeGcovSupportInitialCoverage.info ./build/CMakeGcovSupportCoverage.info

exit 1
