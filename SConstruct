env = Environment(tools = ['mingw'])
env['CC'] = 'gcc'
env['CXX'] = 'gcc'
env['LINK'] = 'g++'

env['CCCOMSTR'] = '[INFO]: Compiling $SOURCE ...'
env['CXXCOMSTR'] = '[INFO]: Compiling $SOURCE ...'
env['LINKCOMSTR'] = '[INFO]: Linking $TARGET ...'

env['BUILD_TARGET'] = ARGUMENTS.get('target', '')
env['DEBUG_MODE'] = ARGUMENTS.get('dbg', 'n')

CCFlags = [
    
]
env.Append(CCFLAGS = [ CCFlags ])

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
