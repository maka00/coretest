namespace applib

module Say =
    open System
    let hello (name: string) =
        String.Format("Hello, \n {0}", name)
