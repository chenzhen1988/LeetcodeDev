#!/bin/bash

echo "start initialize lcov coverage"
./tools/coverage/lcov -d build -z
./tools/coverage/lcov -d build -b . --no-external --initial -c -o ./build/CMakeGcovSupportInitialCoverage.info

exit 1
