#!/bin/bash

echo "start report lcov coverage"
lcov -d build_scons -b . --no-external -c -o ./Coverage/CMakeGcovSupportCoverage.info
genhtml -o ./Coverage/CMakeGcovSupportCoverageReport --prefix=`pwd` ./Coverage/CMakeGcovSupportInitialCoverage.info ./Coverage/CMakeGcovSupportCoverage.info

exit 1
