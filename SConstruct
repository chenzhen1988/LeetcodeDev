env = Environment(tools = ['mingw'])
env['CC'] = 'g++'
env['CXX'] = 'g++'
env['LINK'] = 'g++'

env['CCCOMSTR'] = '[INFO]: Compiling $SOURCE ...'
env['CXXCOMSTR'] = '[INFO]: Compiling $SOURCE ...'
env['LINKCOMSTR'] = '[INFO]: Linking $TARGET ...'

env['BUILD_TARGET'] = ARGUMENTS.get('target', '')
env['DEBUG_MODE'] = ARGUMENTS.get('dbg', 'n')

CCFlags = [
    '-std=c++11',
    '-fprofile-arcs',
    '-ftest-coverage'
]
env.Append(CCFLAGS = [ CCFlags ])
env.Append(LIBS = ['gcov'])

if env['DEBUG_MODE'] == 'y':
    print('--------------------------------------------------------')
    print('|                     Debug mode                       |')
    print('--------------------------------------------------------')
    env.Append(CCFLAGS = [ '-g' ])
    env.Append(LINKFLAGS = [ '-g' ])
    env.Append(ASFLAGS = [ '-g' ])
else:
    print('--------------------------------------------------------')
    print('|                     Normal mode                      |')
    print('--------------------------------------------------------')

src_files = SConscript('./src/SConscript', {'env' : env}, duplicate=0, variant_dir='build_scons')
env.Program('main.exe', src_files)
