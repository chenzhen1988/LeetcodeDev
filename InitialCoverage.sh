#!/bin/bash

echo "start initialize lcov coverage"
rm -rf Coverage
mkdir Coverage
lcov -d build_scons -z
lcov -d build_scons -b . --no-external --initial -c -o ./Coverage/CMakeGcovSupportInitialCoverage.info

exit 1
