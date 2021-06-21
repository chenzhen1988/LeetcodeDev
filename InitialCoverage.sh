#!/bin/bash

echo "start initialize lcov coverage"
lcov -d build_scons -z
lcov -d build_scons -b . --no-external --initial -c -o ./build_scons/CMakeGcovSupportInitialCoverage.info

exit 1
